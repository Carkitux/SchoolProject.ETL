using SchoolProject.ETL.Model.DataClasses.StagingObjectAgr;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.Helper
{
    public class DataGridViewHelper
    {
        public static void UpdateData(DataGridView dataGridView, StagingObject stagingObject)
        {
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

            // Erstellt nun eine Zeile für jeden Datensatz und ordnet die einzelnen Daten zu
            foreach (var datensatz in stagingObject.DataRows)
            {
                string[] dataRow = new string[datensatz.DataRowCells.Count];
                int i = 0;
                foreach (var singledata in datensatz.DataRowCells)
                {
                    dataRow[i] = singledata.Value;
                    i++;
                }
                dataGridView.Rows.Add(dataRow);
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
