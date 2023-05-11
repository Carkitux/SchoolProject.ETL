using SchoolProject.ETL.Model.LogicClasses;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UC2Transform_UCTopData : UserControl
    {
        public UC2Transform_UCTopData()
        {
            InitializeComponent();
        }

        private void button_DataTransferAutomatic_Click(object sender, EventArgs e)
        {
            var labelText = "ACHTUNG!" +
                "\r\nEs werden alle bisherigen Datenzuweisungen zurückgesetzt!";
            using (var form3 = new FormDialogDefaultConfirmation(labelText))
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    Transform.AutomaticDataTransfer();
                    UC2Transform uc = (UC2Transform)Parent.Parent;
                    uc.ReCreateAndValidate();
                }
                else
                {

                }
            }
        }

        private void button_DataTransferManual_Click(object sender, EventArgs e)
        {
            using (var form2 = new FormDialogDataTransfer())
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    UC2Transform uc = (UC2Transform)Parent.Parent;
                    uc.ReCreateAndValidate();
                }
                else
                {
                    UC2Transform uc = (UC2Transform)Parent.Parent;
                    uc.ReCreateAndValidate();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
