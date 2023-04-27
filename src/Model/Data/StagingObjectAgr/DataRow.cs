using SchoolProject.ETL.Logger;
using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Collections.Generic;

namespace SchoolProject.ETL.Model.Data.StagingObjectAgr
{
    public class DataRow : BaseDataClass
    {
        public DataRow(StagingObject stagingObject, string sourceFileName, Filetyp sourcetyp)
        {
            StagingObject = stagingObject;
            SourceFileName = sourceFileName;
            Sourcetyp = sourcetyp;

            LogWriter.Log($"In StagingObject \"{StagingObject.Name}\" : New DataRow \"{ID}\"");
        }
        public DataRow(Guid guid, StagingObject stagingObject, string sourceFileName, Filetyp sourcetyp)
        {
            ID = guid;
            StagingObject = stagingObject;
            SourceFileName = sourceFileName;
            Sourcetyp = sourcetyp;

            LogWriter.Log($"New DataRow \"{ID}\" in StagingObject \"{StagingObject.Name}\"");
        }

        public StagingObject StagingObject { get; set; }
        public string SourceFileName { get; set; }
        public Filetyp Sourcetyp { get; set; }
        public List<DataRowCell> DataRowCells { get; set; } = new List<DataRowCell>();
    }
}