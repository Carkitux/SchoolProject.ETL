using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses;
using SchoolProject.ETL.UI.WinFormsApp.Helper;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform_TopMenu0_Columns : UserControl
    {
        public UserControl2_Transform_TopMenu0_Columns(DataGridView dataGridView, Panel informationPanel)
        {
            InitializeComponent();

            dataGridView1 = dataGridView;
            informationPanel1 = informationPanel;
        }

        private readonly DataGridView dataGridView1;
        private readonly Panel informationPanel1;

        private void button_ColumnGenerate_Click(object sender, EventArgs e)
        {
            using (var form4 = new FormDialog4_GenerateColumns())
            {
                if (form4.ShowDialog(this) == DialogResult.OK)
                {
                    Transform.GenerateAttributes(form4.selectedStagingObjects);

                    UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
                    uc.ReCreateAndValidate();
                }
                else
                {

                }
            }
        }

        private void button_ColumnAdd_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog1_ColumnAdd())
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

        private void button_ColumnEdit_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog1_ColumnAdd())
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

        private void button_ColumnDelete_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedColumns.Count == 0)
            //{
            //    MessageBox.Show("Bitte wählen Sie eine zu löschende Spalte aus.");
            //    return;
            //}
            //Transform.DeleteAttribut(dataGridView1.SelectedColumns[0].Name);
            //dataGridUpdate();

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
