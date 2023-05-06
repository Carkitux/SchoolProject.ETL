using Newtonsoft.Json.Linq;
using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class DataRow : BaseDataClass
    {
        // Constructors
        internal DataRow(StagingObject stagingObject, string sourceFileName)
        {
            StagingObject = stagingObject;
            SourceFileName = sourceFileName;

            LogWriter.Log($"In StagingObject \"{StagingObject.Name}\" : New DataRow \"{ID}\"", Loglevel.Detailliert);
        }
        internal DataRow(Guid guid, StagingObject stagingObject, string sourceFileName)
        {
            ID = guid;
            StagingObject = stagingObject;
            SourceFileName = sourceFileName;

            LogWriter.Log($"New DataRow \"{ID}\" in StagingObject \"{StagingObject.Name}\"", Loglevel.Detailliert);
        }

        // Propertys
        public StagingObject StagingObject { get; private set; }
        public string SourceFileName { get; private set; }
        public List<DataRowCell> DataRowCells { get; private set; } = new List<DataRowCell>();

        // Methods
        internal DataRowCell CreateCell(Attribut attribut, string value)
        {
            var newDataRowCell = new DataRowCell(this, attribut, value);
            DataRowCells.Add(newDataRowCell);
            return newDataRowCell;
        }
        internal void CreateMatchingCells(DataRow sourceDataRow)
        {
            foreach (var cell in sourceDataRow.DataRowCells.Where(x => StagingObject.Attributes.Contains(x.Attribut)))
            {
                var targetAttribut = StagingObject.GetAttribut(cell.Attribut.Name);
                cell.Attribut.AddTransferredAttributes(targetAttribut);
                targetAttribut.AddTransferredAttributes(cell.Attribut);

                var newCell = CreateCell(targetAttribut, cell.Value);
                DataRowCells.Add(newCell);
            }
        }
        public DataRowCell GetDataRowCell(Attribut attribut)
        {
            return DataRowCells.Where(x => x.Attribut.Equals(attribut)).FirstOrDefault();
        }
        public DataRowCell GetDataRowCell(string attributName)
        {
            return DataRowCells.Where(x => x.Attribut.Name == attributName).FirstOrDefault();
        }
    }
}