using SchoolProject.ETL.Model.Common;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;

namespace SchoolProject.ETL.Model.DataClasses.StagingObjectAgr
{
    public class DataRowCell : BaseDataClass
    {
        public DataRowCell(DataRow dataRow, Attribut attribut, string value)
        {
            DataRow = dataRow;
            Attribut = attribut;
            Value = value;

            LogWriter.Log($"In StagingObject \"{DataRow.StagingObject.Name}\" in DataRow \"{DataRow.ID}\" : " +
                $"New DataCell \"{Value}\" with Attribut \"{Attribut.Name}\"", Loglevel.Alles);
        }

        public DataRow DataRow { get; set; }

        private Attribut attribut;
        public Attribut Attribut
        {
            get { return attribut; }
            set
            {
                if (DataRow.StagingObject.Attributes.Contains(value))
                {
                    attribut = value;
                }
            }
        }
        public string Value { get; set; }
    }
}