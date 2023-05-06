using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System;

namespace SchoolProject.ETL.Model.DataClasses
{
    public class DataRowCell : BaseDataClass
    {
        // Constructors
        internal DataRowCell(DataRow dataRow, Attribut attribut, string value)
        {
            DataRow = dataRow;
            Attribut = attribut;
            Value = value;

            LogWriter.Log($"In StagingObject \"{DataRow.StagingObject.Name}\" in DataRow \"{DataRow.ID}\" : " +
                $"New DataCell \"{Value}\" with Attribut \"{Attribut.Name}\"", Loglevel.Detailliert);
        }

        // Fields
        private Attribut attribut;

        // Propertys
        public DataRow DataRow { get; }
        public Attribut Attribut
        {
            get { return attribut; }
            private set 
            { 
                if (DataRow.StagingObject.Attributes.Contains(value))
                {
                    attribut = value;
                }
                else
                {
                    throw new Exception($"Attribut {value.Name} nicht {DataRow.StagingObject.Name} gefunden.");
                }
            }
        }
        public string Value { get; }
    }
}