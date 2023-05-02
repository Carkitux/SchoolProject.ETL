﻿using SchoolProject.ETL.Model.LogicClasses.Transform;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
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
            Transform.AutomaticAllDataTransfer();
            UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
            uc.ReCreateAndValidate();
        }

        private void button_DataTransferManual_Click(object sender, EventArgs e)
        {
            using (var form2 = new FormDialog2_TransferData())
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
                    uc.ReCreateAndValidate();
                }
                else
                {

                }
            }
        }
    }
}
