using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class StagingObject : BaseDataClass
    {
        // Constructors
        internal StagingObject(string name)
        {
            Name = name;

            LogWriter.Log($"New StagingObject \"{Name}\"", Loglevel.Detailliert);
        }

        // Propertys
        public string Name { get; private set; }
        public List<DataRow> DataRows { get; private set; } = new List<DataRow>();
        public List<Attribut> Attributes { get; private set; } = new List<Attribut>();

        // Methods
        internal Attribut CreateAttribut(string name, Datatyp datatyp)
        {
            var newAttribut = new Attribut(this, name, datatyp);
            Attributes.Add(newAttribut);
            return newAttribut;
        }
        internal void DeleteAttribut(string name)
        {
            var targetAttribut = GetAttribut(name);
            targetAttribut.RemoveTransferredAttributes();

            foreach (var dataRow in DataRows)
            {
                var data = dataRow.DataRowCells.Where(x => x.Attribut.Name == targetAttribut.Name).FirstOrDefault();
                dataRow.DataRowCells.Remove(data);
            }

            DataRows.RemoveAll(x => x.DataRowCells.Count == 0);
            Attributes.Remove(targetAttribut);
        }
        internal void DeleteAttribut(Attribut attribut)
        {
            var targetAttribut = attribut;
            targetAttribut.RemoveTransferredAttributes();

            foreach (var dataRow in DataRows)
            {
                var data = dataRow.DataRowCells.Where(x => x.Attribut.Name == targetAttribut.Name).FirstOrDefault();
                dataRow.DataRowCells.Remove(data);
            }

            DataRows.RemoveAll(x => x.DataRowCells.Count == 0);
            Attributes.Remove(targetAttribut);
        }
        internal void DeleteAllAttribut()
        {
            var deleteAttributes = new List<string>();

            foreach (var attribut in Attributes)
            {
                deleteAttributes.Add(attribut.Name);
            }
            foreach (var item in deleteAttributes)
            {
                DeleteAttribut(item);
            }
        }
        public Attribut GetAttribut(string name)
        {
            return Attributes.Where(x => x.Name == name).FirstOrDefault();
        }

        internal DataRow CreateDataRow(string sourceFileName)
        {
            var newDataRowCell = new DataRow(this, sourceFileName);
            DataRows.Add(newDataRowCell);
            return newDataRowCell;
        }
        internal DataRow CreateDataRow(Guid guid, string sourceFileName)
        {
            var newDataRowCell = new DataRow(guid, this, sourceFileName);
            DataRows.Add(newDataRowCell);
            return newDataRowCell;
        }
        public DataRow GetDataRow(Guid dataRowGuid)
        {
            return DataRows.Where(x => x.ID == dataRowGuid).FirstOrDefault();
        }
    }
}
