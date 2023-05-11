using SchoolProject.ETL.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogGenerateColumns : Form
    {
        public FormDialogGenerateColumns()
        {
            InitializeComponent();

            comboBox_stagingObject.Items.Add("Alle kombinieren");
            foreach (var item in StagingArea.StObjects)
            {
                comboBox_stagingObject.Items.Add(item.Name);
            }
        }

        public List<StagingObject> selectedStagingObjects = new List<StagingObject>();

        private void button_Okay_Click(object sender, EventArgs e)
        {
            if ((string)comboBox_stagingObject.SelectedItem == "Alle kombinieren")
            {
                selectedStagingObjects.AddRange(StagingArea.StObjects);
            }
            else
            {
                var stagingObject = StagingArea.StObjects.Where(x => x.Name == (string)comboBox_stagingObject.SelectedItem).First();
                selectedStagingObjects.Add(stagingObject);
            }
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
