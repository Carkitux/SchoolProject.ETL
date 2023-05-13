using System;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogDefaultConfirmation : Form
    {
        public FormDialogDefaultConfirmation(string labelText)
        {
            InitializeComponent();

            label1.Text = labelText;

            Refresh();
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
