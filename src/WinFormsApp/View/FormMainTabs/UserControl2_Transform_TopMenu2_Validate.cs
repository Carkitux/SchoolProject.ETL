using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform_TopMenu2_Validate : UserControl
    {
        public UserControl2_Transform_TopMenu2_Validate()
        {
            InitializeComponent();
        }

        private void button_DataValidate_Click(object sender, EventArgs e)
        {
            List<DataRowCell> failedCells = new List<DataRowCell>();
            foreach (var attribut in StagingArea.TransformStObject.Attributes.Where(x => x.Datatyp == Model.Enums.Datatyp.EMail))
            {
                var cells = attribut.GetDataRowCells();

                foreach (var cell in cells)
                {
                    if (!Validation.ValidateEMail(cell.Value))
                    {
                        failedCells.Add(cell);
                    }
                }
            }

            foreach (var failedCell in failedCells)
            {
                using (var form5 = new FormDialog5_Validation(failedCell))
                {
                    if (form5.ShowDialog(this) == DialogResult.OK)
                    {
                        UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
                        uc.ReCreateAndValidate();
                    }
                    else
                    {
                        UserControl2_Transform uc = (UserControl2_Transform)Parent.Parent;
                        uc.ReCreateAndValidate();
                    }
                }
            }
        }
    }
}
