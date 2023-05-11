using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace SchoolProject.ETL.Model.LogicClasses
{
    public class Transform
    {
        public static void DataTransfer(string sourceStObjName, List<string> sourceAttributeNameList, string targetAttributName)
        {
            var TransformStObj = StagingArea.TransformStObject;

            var sourceStObj = StagingArea.GetStagingObject(sourceStObjName);
            var sourceAttributeList = sourceStObj.Attributes.Where(x => sourceAttributeNameList.Contains(x.Name)).ToList();
            var targetAttribut = TransformStObj.GetAttribut(targetAttributName);

            foreach (var sourceDataRows in sourceStObj.DataRows)
            {
                var sourceCells = sourceDataRows.DataRowCells.Where(x => sourceAttributeList.Where(y => y.Name == x.Attribut.Name).Count() > 0).ToList();
                string sourceValue = Merge(sourceCells);

                DataRow transformDataRow = TransformStObj.DataRows.Where(x => x.SourceFileName == sourceDataRows.SourceFileName && x.ID == sourceDataRows.ID).FirstOrDefault();
                DataRowCell newCell;
                if (transformDataRow is null)
                {
                    transformDataRow = TransformStObj.CreateDataRow(sourceDataRows.ID, sourceDataRows.SourceFileName);
                    newCell = transformDataRow.CreateCell(targetAttribut, sourceValue);
                }
                else
                {
                    newCell = transformDataRow.CreateCell(targetAttribut, sourceValue);
                }

                newCell.Attribut.AddTransferredAttributes(targetAttribut);
                targetAttribut.AddTransferredAttributes(newCell.Attribut);
            }
        }
        public static void AutomaticDataTransfer()
        {
            var TransformStObj = StagingArea.TransformStObject;
            TransformStObj.DataRows.Clear();

            var oldDataRows = StagingArea.StObjects.SelectMany(x => x.DataRows).ToList();

            foreach (var oldDataRow in oldDataRows)
            {
                // Erstellen der Datenzeile und erstellen der Datenzellen darunter die die gleichen Attributte teilen
                var newDataRow = TransformStObj.CreateDataRow(oldDataRow.ID, oldDataRow.SourceFileName);
                newDataRow.CreateMatchingCells(oldDataRow);
            }
        }

        //public static void StornoTransferData(string _quellStObj, string _quellAttribut, string _zielAttribut)
        //{

        //}

        private static string Merge(List<DataRowCell> quellsingleDatas)
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

        public static void CreateAttribut(string columnName, Datatyp datatyp)
        {
            var TransformStObj = StagingArea.TransformStObject;
            TransformStObj.CreateAttribut(columnName, datatyp);
        }
        public static void DeleteAttribut(string name)
        {
            var TransformStObj = StagingArea.TransformStObject;
            TransformStObj.DeleteAttribut(name);
        }
        public static void GenerateAttributes(List<StagingObject> stagingObjects)
        {
            var TransformStObj = StagingArea.TransformStObject;
            TransformStObj.DeleteAllAttribut();

            foreach (var stagingObject in stagingObjects)
            {
                foreach (var stObjattribut in stagingObject.Attributes)
                {
                    if (TransformStObj.Attributes.Where(x => x.Name == stObjattribut.Name).Count() > 0)
                    {
                        continue;
                    }
                    TransformStObj.CreateAttribut(stObjattribut.Name, Datatyp.unknown);
                }
            }
        }
    }
}