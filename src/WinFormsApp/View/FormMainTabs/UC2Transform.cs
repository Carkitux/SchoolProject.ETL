using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses;
using SchoolProject.ETL.UI.WinFormsApp.Helper;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UC2Transform : UserControl
    {
        public UC2Transform()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dataGridView1.MultiSelect = false;
            panel3.Visible = false;

            ReCreateAndValidate();
        }

        private UserControl activeMenuUserControl;

        private void button_ColumnMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UC2Transform_UCTopColumns(dataGridView1), (Button)sender);
        }

        private void button_DataTransferMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UC2Transform_UCTopData(), (Button)sender);
        }

        private void button_DataValidate_Click(object sender, EventArgs e)
        {
            List<DataRowCell> failedCells = Validation.Validate();

            foreach (var failedCell in failedCells)
            {
                using (var form5 = new FormDialogValidation(failedCell, failedCells.Count - failedCells.IndexOf(failedCell)))
                {
                    if (form5.ShowDialog(this) == DialogResult.OK)
                    {
                        ReCreateAndValidate();
                    }
                    else
                    {
                        ReCreateAndValidate();
                    }
                }
            }
        }

        private void MenuUserControlSwitch(UserControl newUserConrol, Button currentButton)
        {
            button_ColumnMenu.BackColor = Color.LightGray;
            button_DataTransferMenu.BackColor = Color.LightGray;
            button_DataValidate.BackColor = Color.LightGray;

            if (activeMenuUserControl?.Name == newUserConrol.Name)
            {
                newUserConrol.Dispose();
                activeMenuUserControl.Dispose();
                activeMenuUserControl = null;
                panel3.Visible = false;
            }
            else
            {
                currentButton.BackColor = Color.WhiteSmoke;
                activeMenuUserControl?.Dispose();
                activeMenuUserControl = newUserConrol;
                activeMenuUserControl.Dock = DockStyle.Fill;
                activeMenuUserControl.Parent = panel3;
                panel3.Visible = true;
            }
        }

        public void ReCreateAndValidate()
        {
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);

            if (StagingArea.TransformStObject.Attributes.Count() == 0)
            {
                button_DataTransferMenu.Enabled = false;
                button_DataValidate.Enabled = false;
            }
            else
            {
                button_DataTransferMenu.Enabled = true;
                button_DataValidate.Enabled = true;
            }
        }
    }
}
