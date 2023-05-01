using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialog3_Confirmation : Form
    {
        public FormDialog3_Confirmation()
        {
            InitializeComponent();
        }

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
