using SchoolProject.ETL.Model.Data;
using SchoolProject.ETL.ModelLogic.Transform;
using SchoolProject.ETL.WinFormsApp.Helper;
using System;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl2Transform_Menu1Columns : UserControl
    {
        public UserControl2Transform_Menu1Columns(DataGridView dataGridView, Panel informationPanel)
        {
            InitializeComponent();

            dataGridView1 = dataGridView;
            informationPanel1 = informationPanel;
        }

        private readonly DataGridView dataGridView1;
        private readonly Panel informationPanel1;

        private void buttonColumnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void buttonColumnAdd_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog_SpalteHinzufuegen())
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);
                }
                else
                {

                }
            }
        }

        private void buttonColumnEdit_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog_SpalteHinzufuegen())
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);
                }
                else
                {

                }
            }
        }

        private void buttonColumnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedColumns.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine zu löschende Spalte aus.");
                return;
            }
            Transform.DeleteAttribut(dataGridView1.SelectedColumns[0].Name);
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);
        }
    }
}
