using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System.Collections.Generic;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class StagingObject : BaseDataClass
    {
        public StagingObject(string name)
        {
            Name = name;

            LogWriter.Log($"New StagingObject \"{Name}\"", Loglevel.Alles);
        }

        public string Name { get; private set; }
        public List<DataRow> DataRows { get; set; } = new List<DataRow>();
        public List<Attribut> Attributes { get; set; } = new List<Attribut>();
    }
}
