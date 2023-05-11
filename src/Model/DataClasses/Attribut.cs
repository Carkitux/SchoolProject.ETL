﻿using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class Attribut
    {
        // Constructors
        internal Attribut(StagingObject stagingObject, string name, Datatyp datatyp)
        {
            StagingObject = stagingObject;
            Name = name;
            Datatyp = datatyp;

            LogWriter.Log($"In StagingObject \"{StagingObject.Name}\" : New Attribut \"{Name}\" with Datatyp \"{Datatyp}\"", Loglevel.Detailliert);
        }

        // Propertys
        public StagingObject StagingObject { get; private set; }
        public string Name { get; private set; }
        public Datatyp Datatyp { get; private set; }
        public List<string> TransferredTo { get; } = new List<string>();
        public List<string> TransferredFrom { get; } = new List<string>();

        // Methods
        internal void AddTransferredAttributes(Attribut targetAttribut)
        {
            if (!this.TransferredTo.Contains($"{targetAttribut.StagingObject.Name} // {targetAttribut.Name}"))
            {
                this.TransferredTo.Add($"{targetAttribut.StagingObject.Name} // {targetAttribut.Name}");
            }
            if (!targetAttribut.TransferredFrom.Contains($"{StagingObject.Name} // {Name}"))
            {
                targetAttribut.TransferredFrom.Add($"{StagingObject.Name} // {Name}");
            }
        }
        internal void RemoveTransferredAttributes()
        {
            var allAttributes = StagingArea.StObjects
                .SelectMany(x => x.Attributes)
                .Where(x => x.TransferredTo.Contains($"{StagingObject.Name} // {Name}"))
                .ToList();
            foreach (var attribute in allAttributes)
            {
                attribute.TransferredTo.Remove($"{StagingObject.Name} // {Name}");
            }
        }
        public void Edit(string newName, Datatyp newDatatyp)
        {
            Name = newName;
            Datatyp = newDatatyp;
        }

        public List<DataRowCell> GetAssociatedDataRowCells()
        {
            var list = StagingObject.DataRows
                .SelectMany(x => x.DataRowCells)
                .Where(y => y.Attribut.Equals(this))
                .ToList();
            return list;
        }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            if (!(obj is Attribut other))
            {
                return false;
            }

            return Name == other.Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
