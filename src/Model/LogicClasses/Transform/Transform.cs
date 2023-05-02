using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace SchoolProject.ETL.Model.LogicClasses.Transform
{
    public class Transform
    {
        public static void DataTransfer(string _quellStObj, List<string> _quellAttribut, string _zielAttribut)
        {
            StagingObject TransformStObj = StagingArea.TransformStObject;

            StagingObject quellStObj = StagingArea.StObjects.Where(x => x.Name == _quellStObj).First();
            List<Attribut> quellAttribute = quellStObj.Attributes.Where(x => _quellAttribut.Contains(x.Name)).ToList();
            Attribut zielAttribut = TransformStObj.Attributes.Where(x => x.Name == _zielAttribut).First();

            foreach (DataRow quelldatenSatz in quellStObj.DataRows)
            {
                List<DataRowCell> quellsingleDatas = quelldatenSatz.DataRowCells.Where(x => quellAttribute.Where(y => y.Name == x.Attribut.Name).Count() > 0).ToList();
                string quellInhalt = Zusammenfuegen(quellsingleDatas);

                DataRow TransformDatenSatz = TransformStObj.DataRows.Where(x => x.SourceFileName == quelldatenSatz.SourceFileName && x.ID == quelldatenSatz.ID).FirstOrDefault();
                if (TransformDatenSatz is null)
                {
                    DataRow newTransformDatensatz = new DataRow(quelldatenSatz.ID, TransformStObj, quelldatenSatz.SourceFileName, quelldatenSatz.Sourcetyp);
                    DataRowCell newTransformSingleData = new DataRowCell(newTransformDatensatz, zielAttribut, quellInhalt);
                    newTransformDatensatz.DataRowCells.Add(newTransformSingleData);
                    TransformStObj.DataRows.Add(newTransformDatensatz);
                }
                else
                {
                    DataRowCell newTransformSingleData = new DataRowCell(TransformDatenSatz, zielAttribut, quellInhalt);
                    TransformDatenSatz.DataRowCells.Add(newTransformSingleData);
                }
            }
            //quellAttribute.ForEach(x => x.WasTransferred = true);
            zielAttribut.WasTransferredTo.AddRange(quellAttribute);
        }

        //public static void StornoTransferData(string _quellStObj, string _quellAttribut, string _zielAttribut)
        //{

        //}

        private static string Zusammenfuegen(List<DataRowCell> quellsingleDatas)
        {
            string neuerInhalt = string.Empty;
            int i = 0;
            foreach (var item in quellsingleDatas)
            {
                if (quellsingleDatas.Count() - i == 1)
                {
                    neuerInhalt += item.Value;
                }
                else
                {
                    neuerInhalt += item.Value + " ";
                }
                i++;
            }
            return neuerInhalt;
        }

        //public static void Splitten(string _quellStObj, string _quellAttribut, string _zielAttribut)
        //{

        //}

        //public static void Ersetzen(string _quellStObj, string _quellAttribut, string _zielAttribut)
        //{

        //}

        public static void CreateAttribut(string name, Datatyp datatyp)
        {
            var TransformStObj = StagingArea.TransformStObject;
            var newAttribut = new Attribut(TransformStObj, name, datatyp);
            TransformStObj.Attributes.Add(newAttribut);
        }

        public static void DeleteAttribut(string attributName)
        {
            var TransformStObj = StagingArea.TransformStObject;

            var selectedAttribut = TransformStObj.Attributes.Where(x => x.Name == attributName).First();
            selectedAttribut.WasTransferredFrom.ForEach(x => x.WasTransferredTo.Remove(selectedAttribut));
            selectedAttribut.WasTransferredTo = null;

            foreach (var dataRow in TransformStObj.DataRows)
            {
                var data = dataRow.DataRowCells.Where(x => x.Attribut.Name == selectedAttribut.Name).FirstOrDefault();
                dataRow.DataRowCells.Remove(data);
            }

            TransformStObj.DataRows.RemoveAll(x => x.DataRowCells.Count == 0);
            TransformStObj.Attributes.Remove(selectedAttribut);
        }

        public static void GenerateAllAttributes(List<StagingObject> stagingObjects)
        {
            var TransformStObj = StagingArea.TransformStObject;
            var deleteAttributes = new List<string>();

            foreach (var attribut in TransformStObj.Attributes)
            {
                deleteAttributes.Add(attribut.Name);              
            }
            foreach (var item in deleteAttributes)
            {
                DeleteAttribut(item);
            }

            foreach (var stagingObject in stagingObjects)
            {
                foreach (var stObjattribut in stagingObject.Attributes)
                {
                    if (TransformStObj.Attributes.Where(x => x.Name == stObjattribut.Name).Count() > 0)
                    {
                        continue;
                    }
                    CreateAttribut(stObjattribut.Name, Datatyp.Unknown);
                }
            }
        }

        public static void AutomaticAllDataTransfer()
        {
            var TransformStObj = StagingArea.TransformStObject;

            foreach (var stagingObject in StagingArea.StObjects)
            {
                foreach (var dataRow in stagingObject.DataRows)
                {
                    foreach (var dataRowCell in dataRow.DataRowCells)
                    {
                        var targetDataRow = TransformStObj.DataRows.Where(x => x.SourceFileName == dataRow.SourceFileName && x.ID == dataRow.ID).FirstOrDefault();
                        var targetAttribut = TransformStObj.Attributes.Where(x => x.Name == dataRowCell.Attribut.Name).FirstOrDefault();
                        
                        if (targetAttribut is null)
                        {
                            continue;
                        }

                        if (targetDataRow is null)
                        {
                            var newTransformDataRow = new DataRow(dataRow.ID, TransformStObj, dataRow.SourceFileName, dataRow.Sourcetyp);
                            var newTransformDataRowCell = new DataRowCell(newTransformDataRow, targetAttribut, dataRowCell.Value);
                            newTransformDataRow.DataRowCells.Add(newTransformDataRowCell);
                            TransformStObj.DataRows.Add(newTransformDataRow);
                        }
                        else
                        {
                            var newTransformDataRowCell = new DataRowCell(targetDataRow, targetAttribut, dataRowCell.Value);
                            targetDataRow.DataRowCells.Add(newTransformDataRowCell);
                        }

                        if (!dataRowCell.Attribut.WasTransferredTo.Contains(targetAttribut))
                        {
                            dataRowCell.Attribut.WasTransferredTo.Add(targetAttribut);
                        }
                        if (!targetAttribut.WasTransferredFrom.Contains(dataRowCell.Attribut))
                        {
                            targetAttribut.WasTransferredFrom.Add(dataRowCell.Attribut);
                        }
                    }
                }
            }
        }
    }
}