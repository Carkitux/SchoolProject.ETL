using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System.Collections.Generic;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class Attribut : BaseDataClass
    {
        public Attribut(StagingObject stagingObject, string name, Datatyp datatyp)
        {
            StagingObject = stagingObject;

            Name = name;
            Datatyp = datatyp;

            LogWriter.Log($"In StagingObject \"{StagingObject.Name}\" : New Attribut \"{Name}\" with Datatyp \"{Datatyp}\"", Loglevel.Alles);
        }

        // Parent
        public StagingObject StagingObject { get; set; }

        public string Name { get; set; }
        public Datatyp Datatyp { get; set; }
        public List<Attribut> WasTransferredTo { get; set; } = new List<Attribut>();
        public List<Attribut> WasTransferredFrom { get; set; } = new List<Attribut>();
        public List<DataRowCell> DataRowCells { get; set; } = new List<DataRowCell>();

        public override string ToString()
        {
            return Name;
        }
    }
}
