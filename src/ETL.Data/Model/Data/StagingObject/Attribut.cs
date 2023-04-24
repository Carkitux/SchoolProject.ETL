using ETL_SFC_Library.Model.Common;
using System;
using System.Collections.Generic;

namespace ETL_SFC_Model
{
    public class Attribut : BaseDataClass
    {
        public Attribut(StagingObject stagingObject, string name, Datatyp datatyp)
        {
            StagingObject = stagingObject;

            Name = name;
            Datatyp = datatyp;
            WasTransferred = false;

            LogWriter.Log($"In StagingObject \"{StagingObject.Name}\" : New Attribut \"{Name}\" with Datatyp \"{Datatyp}\"");
        }
        
        // Parent
        public StagingObject StagingObject { get; set; }
        
        public string Name { get; set; }
        public Datatyp Datatyp { get; set; }
        public bool WasTransferred { get; set; }
        public List<Attribut> WasTransferredTo { get; set; } = new List<Attribut>();
        public List<DataRowCell> DataRowCells { get; set; } = new List<DataRowCell>();

        public override string ToString()
        {
            return Name;
        }
    }
}
