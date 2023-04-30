using ETL_SFC_WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform_TopMenu1_Data : UserControl
    {
        public UserControl2_Transform_TopMenu1_Data()
        {
            InitializeComponent();
        }

        private void button_DataTransferAutomatic_Click(object sender, EventArgs e)
        {

        }

        private void button_DataTransferManual_Click(object sender, EventArgs e)
        {
            using (var form2 = new FormDialog2_TransferData())
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
                    uc.dataGridUpdate();
                }
                else
                {

                }
            }
        }
    }
}
