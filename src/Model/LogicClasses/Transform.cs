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
        public static void DataTransfer(string sourceStObjName, string sourceAttributeName, string targetAttributName)
        {
            var transformStObj = StagingArea.TransformStObject;
            var sourceStObj = StagingArea.GetStagingObject(sourceStObjName);
            var sourceAttribute = sourceStObj.Attributes
                .Where(x => x.Name == sourceAttributeName)
                .FirstOrDefault();
            var targetAttribut = transformStObj.GetAttribut(targetAttributName);

            foreach (var sourceDataRows in sourceStObj.DataRows)
            {
                var sourceCellValue = sourceDataRows.DataRowCells
                    .Where(x => x.Attribut.Equals(sourceAttribute))
                    .FirstOrDefault().Value;
                var transformDataRow = transformStObj.DataRows
                    .Where(x => x.SourceFileName == sourceDataRows.SourceFileName && x.ID == sourceDataRows.ID)
                    .FirstOrDefault();

                var newCell = CreateDataRowCellAndOrDataRow(transformStObj, sourceDataRows, sourceCellValue, targetAttribut, ref transformDataRow);

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
        public static void DataMerge(string sourceStObjName, List<string> sourceAttributeNameList, string connector)
        {
            var mergeStgObj = StagingArea.SplitMergeStObject;
            var sourceStObj = StagingArea.GetStagingObject(sourceStObjName);
            var sourceAttributeList = sourceStObj.Attributes
                .Where(x => sourceAttributeNameList.Contains(x.Name))
                .ToList();

            foreach (var sourceDataRows in sourceStObj.DataRows)
            {
                var sourceCells = sourceDataRows.DataRowCells
                    .Where(x => sourceAttributeList.Where(y => y.Name == x.Attribut.Name).Count() > 0)
                    .ToList();

                string newValue, mergeAttributName;
                GetMergedValueAndAttributeName(connector, sourceCells, out newValue, out mergeAttributName);

                var mergeAttribut = SearchOrCreateMatchingAttribute(mergeStgObj, mergeAttributName);
                var mergeDataRow = mergeStgObj.DataRows
                    .Where(x => x.SourceFileName == sourceDataRows.SourceFileName && x.ID == sourceDataRows.ID)
                    .FirstOrDefault();

                CreateDataRowCellAndOrDataRow(mergeStgObj, sourceDataRows, newValue, mergeAttribut, ref mergeDataRow);
            }
        }
        //public static void DataSplit(string _quellStObj, string _quellAttribut, string _zielAttribut)
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

        private static void GetMergedValueAndAttributeName(string connector, List<DataRowCell> sourceCells, out string newValue, out string mergeAttributName)
        {
            newValue = string.Empty;
            mergeAttributName = string.Empty;
            int i = 0;
            foreach (var item in sourceCells)
            {
                mergeAttributName = item.DataRow.StagingObject.Name + " // ";
                if (sourceCells.Count() - i == 1)
                {
                    newValue += item.Value;
                    mergeAttributName += item.Attribut.Name;
                }
                else
                {
                    newValue += item.Value + connector;
                    mergeAttributName += item.Attribut.Name + " & ";
                }
                i++;
            }
        }
        private static Attribut SearchOrCreateMatchingAttribute(StagingObject mergeStgObj, string mergeAttributName)
        {
            var mergeAttribut = mergeStgObj.GetAttribut(mergeAttributName);
            if (mergeAttribut is null)
            {
                mergeAttribut = mergeStgObj.CreateAttribut(mergeAttributName, Datatyp.unknown);
            }

            return mergeAttribut;
        }
        private static DataRowCell CreateDataRowCellAndOrDataRow(StagingObject mergeStgObj, DataRow sourceDataRows, string newValue, Attribut mergeAttribut, ref DataRow mergeDataRow)
        {
            DataRowCell newCell;
            if (mergeDataRow is null)
            {
                mergeDataRow = mergeStgObj.CreateDataRow(sourceDataRows.ID, sourceDataRows.SourceFileName);
                newCell = mergeDataRow.CreateCell(mergeAttribut, newValue);
            }
            else
            {
                newCell = mergeDataRow.CreateCell(mergeAttribut, newValue);
            }

            return newCell;
        }
    }
}