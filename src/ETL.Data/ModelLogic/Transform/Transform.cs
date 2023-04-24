using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ETL_SFC_Model
{
    public class Transform
    {
        public static void TransferData(string _quellStObj, List<string> _quellAttribut, string _zielAttribut)
        {
            StagingObject TransformStObj = StagingArea.TransformStObject;

            StagingObject quellStObj = StagingArea.StObjects.Where(x => x.Name == _quellStObj).First();
            List<Attribut> quellAttribute = quellStObj.Attributes.Where(x => _quellAttribut.Contains(x.Name)).ToList();
            Attribut zielAttribut = TransformStObj.Attributes.Where(x => x.Name == _zielAttribut).First();

            foreach (DataRow quelldatenSatz in quellStObj.DataRows)
            {
                List<DataRowCell> quellsingleDatas = quelldatenSatz.DataRowCells.Where(x => quellAttribute.Where(y => y.Name == x.Attribut.Name).Count() > 0).ToList();
                string quellInhalt = Transform.Zusammenfuegen(quellsingleDatas);

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
            quellAttribute.ForEach(x => x.WasTransferred = true);
            zielAttribut.WasTransferredTo.AddRange(quellAttribute);
        }

        public static void StornoTransferData(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        private static string Zusammenfuegen(List<DataRowCell> quellsingleDatas)
        {
            string neuerInhalt = string.Empty;
            int i = 0;
            foreach (var item in quellsingleDatas)
            {
                if (quellsingleDatas.Count() - i == 1)
                {
                    neuerInhalt = neuerInhalt + item.Value;
                }
                else
                {
                    neuerInhalt = neuerInhalt + item.Value + " ";
                }
                i++;
            }
            return neuerInhalt;
        }

        public static void Splitten(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        public static void Ersetzen(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        public static void CreateAttribut(string name, Datatyp datentyp)
        {
            StagingObject TransformStObj = StagingArea.TransformStObject;
            Attribut newAttribut = new Attribut(TransformStObj, name, datentyp);
            TransformStObj.Attributes.Add(newAttribut);
        }

        public static void DeleteAttribut(string attributsName)
        {
            StagingObject TransformStObj = StagingArea.TransformStObject;
            Attribut selectedAttribut = TransformStObj.Attributes.Where(x => x.Name == attributsName).First();
            selectedAttribut.WasTransferredTo.ForEach(x => x.WasTransferred = false);
            foreach (var datensatz in TransformStObj.DataRows)
            {
                DataRowCell singleData = datensatz.DataRowCells.Where(x => x.Attribut == selectedAttribut).First();
                datensatz.DataRowCells.Remove(singleData);
            }
            TransformStObj.DataRows.RemoveAll(x => x.DataRowCells.Count == 0);
            TransformStObj.Attributes.Remove(selectedAttribut);
        }
    }
}