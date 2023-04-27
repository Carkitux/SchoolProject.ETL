using SchoolProject.ETL.Logger;
using SchoolProject.ETL.Model.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace SchoolProject.ETL.Model.Data.StagingObjectAgr
{
    public class StagingObject : BaseDataClass
    {
        public StagingObject(string name)
        {
            Name = name;

            LogWriter.Log($"New StagingObject \"{Name}\"");
        }

        public string Name { get; private set; }
        public List<DataRow> DataRows { get; set; } = new List<DataRow>();
        public List<Attribut> Attributes { get; set; } = new List<Attribut>();
    }
}
