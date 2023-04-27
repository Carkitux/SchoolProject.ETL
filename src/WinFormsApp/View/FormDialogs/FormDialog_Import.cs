using SchoolProject.ETL.Model.Data.StagingObjectAgr;
using SchoolProject.ETL.ModelLogic.Serializer;
using SchoolProject.ETL.WinFormsApp.Helper;
using System;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class FormDialog_CSVImport : Form
    {
        public FormDialog_CSVImport()
        {
            InitializeComponent();
        }

        public string FileName = string.Empty;
        public string Seperator = string.Empty;
        public bool HasHeader = false;
        private StagingObject tempStagingObject;

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            Seperator = textBoxSeperator.Text;
            HasHeader = checkBoxHasHeader.Checked;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxSeperator_TextChanged(object sender, EventArgs e)
        {
            Seperator = textBoxSeperator.Text;
            Refresh();
        }

        private void checkBoxHasHeader_CheckedChanged(object sender, EventArgs e)
        {
            HasHeader = checkBoxHasHeader.Checked;
            Refresh();
        }

        private void FormDialog_Import_Load(object sender, EventArgs e)
        {
            label1.Text = FileName;
            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

            tempStagingObject = CSV.LoadTempFromCSV(FileName, Seperator, HasHeader, 12);

            // Einstellungen für die Tabelle
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

            // Erstellt die Spalten und befüllt die Tabelle
            DataGridViewHelper.UpdateData(dataGridView1, tempStagingObject);
        }
    }
}
