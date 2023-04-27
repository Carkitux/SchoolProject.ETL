using SchoolProject.ETL.Model.Data;
using SchoolProject.ETL.Model.Data.StagingObjectAgr;
using SchoolProject.ETL.ModelLogic.Transform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl2Transform : UserControl
    {
        public UserControl2Transform()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dataGridView1.MultiSelect = false;
            panel3.Visible = false;
        }

        private UserControl activeMenuUserControl;

        private void button_SpalteLoeschen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedColumns.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine zu löschende Spalte aus.");
                return;
            }
            Transform.DeleteAttribut(dataGridView1.SelectedColumns[0].Name);
            dataGridUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form2 = new FormDialog_TransferData())
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridUpdate();
                }
                else
                {

                }
            }
        }

        private void dataGridUpdate()
        {
            StagingObject TransformStObj = StagingArea.TransformStObject;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            // Holt sich alle Header der Datei und erstellt demnach die Spalten der Tabelle
            List<string> headers = new List<string>();
            TransformStObj.Attributes?.ForEach(data => headers.Add(data.Name));
            foreach (var header in headers.Distinct())
            {
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = header,
                    Name = header,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dataGridView1.Columns.Add(column);
            }

            // Erstellt nun eine Zeile für jeden Datensatz und ordnet die einzelnen Daten zu
            foreach (var dataRow in TransformStObj.DataRows)
            {
                var dataGridRow = new string[dataRow.DataRowCells.Count];
                var i = 0;

                foreach (var dataRowCell in dataRow.DataRowCells)
                {
                    dataGridRow[i] = dataRowCell.Value;
                    i++;
                }

                dataGridView1.Rows.Add(dataGridRow);
            }
        }

        private void buttonColumnMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UserControl2Transform_Menu1Columns(dataGridView1, panel4), (Button)sender);
        }

        private void MenuUserControlSwitch(UserControl newUserConrol, Button currentButton)
        {
            buttonColumnMenu.BackColor = Color.LightGray;

            if (activeMenuUserControl?.Name == newUserConrol.Name)
            {
                newUserConrol.Dispose();
                activeMenuUserControl.Dispose();
                activeMenuUserControl = null;
                panel3.Visible = false;
            }
            else
            {
                currentButton.BackColor = Color.WhiteSmoke;
                activeMenuUserControl?.Dispose();
                activeMenuUserControl = newUserConrol;
                activeMenuUserControl.Dock = DockStyle.Fill;
                activeMenuUserControl.Parent = panel3;
                panel3.Visible = true;
            }
        }
    }
}
