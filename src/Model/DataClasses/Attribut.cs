using SchoolProject.ETL.Model.Common;
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
        public int MaxLength { get; set; }
        public List<Attribut> TransferredTo { get; } = new List<Attribut>();
        public List<Attribut> TransferredFrom { get; } = new List<Attribut>();

        // Methods
        internal void AddTransferredAttributes(Attribut targetAttribut)
        {
            if (!this.TransferredTo.Contains(targetAttribut))
            {
                this.TransferredTo.Add(targetAttribut);
            }
            if (!targetAttribut.TransferredFrom.Contains(this))
            {
                targetAttribut.TransferredFrom.Add(this);
            }
        }
        internal void RemoveTransferredAttributes()
        {
            foreach (var attribute in TransferredFrom)
            {
                attribute.TransferredTo.Remove(this);
            }
            TransferredFrom.Clear();
        }
        internal void RemoveTransferredAttributes(Attribut attribut)
        {
            attribut.TransferredTo.Remove(this);
            TransferredFrom.Remove(attribut);
        }
        public void Edit(string newName, Datatyp newDatatyp, int maxLength)
        {
            Name = newName;
            Datatyp = newDatatyp;
            MaxLength = maxLength;


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
