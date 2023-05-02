using SchoolProject.ETL.Model.DataClasses;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.Helper
{
    public class DataGridViewHelper
    {
        public static void UpdateData(DataGridView dataGridView, StagingObject stagingObject)
        {
            //Setzt die Tabelle vor dem neugenerieren zurück
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Holt sich alle Attribute der Datei und erstellt demnach die Spalten der Tabelle
            foreach (var attribut in stagingObject.Attributes)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = attribut.Name,
                    Name = attribut.Name,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dataGridView.Columns.Add(column);
            }

            // Erstellt nun eine Zeile für jeden Datensatz und ordnet die einzelnen Daten
            // anhand übereinstimmender Attribute/Header zu
            foreach (var dataRow in stagingObject.DataRows)
            {
                var dataGridRow = new string [dataGridView.Columns.Count];
                foreach (var data in dataRow.DataRowCells)
                {
                    var i = 0;
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        if (data.Attribut.Name == column.Name)
                        {
                            dataGridRow[i] = data.Value;
                        }
                        i++;
                    }
                }
                dataGridView.Rows.Add(dataGridRow);
            }
        }

        public static DataGridView Create(Control parent)
        {
            DataGridView dataGridView = new DataGridView
            {
                Parent = parent,
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                EditMode = DataGridViewEditMode.EditProgrammatically,
                SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect
            };

            return dataGridView;
        }
    }
}
