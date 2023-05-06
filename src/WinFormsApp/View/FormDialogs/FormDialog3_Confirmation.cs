using System;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialog3_Confirmation : Form
    {
        public FormDialog3_Confirmation(string labelText)
        {
            InitializeComponent();

            label1.Text = labelText;
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
