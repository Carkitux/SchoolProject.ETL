using SchoolProject.ETL.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialog4_GenerateColumns : Form
    {
        public FormDialog4_GenerateColumns()
        {
            InitializeComponent();

            comboBox_stagingObject.Items.Add("Alle kombinieren");
            foreach (var item in StagingArea.StObjects)
            {
                comboBox_stagingObject.Items.Add(item.Name);
            }
        }

        List<StagingObject> selectedStagingObjectName = new List<StagingObject>();

        private void button_Okay_Click(object sender, EventArgs e)
        { 

            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
