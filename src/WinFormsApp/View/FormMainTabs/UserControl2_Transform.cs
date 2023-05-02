using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.UI.WinFormsApp.Helper;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform : UserControl
    {
        public UserControl2_Transform()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dataGridView1.MultiSelect = false;
            panel3.Visible = false;

            ReCreateAndValidate();
        }

        private UserControl activeMenuUserControl;
        private UserControl activeLeftMenuUserControl;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_ColumnMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UserControl2_Transform_TopMenu0_Columns(dataGridView1, panel4), (Button)sender);
        }

        private void button_DataTransferMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UserControl2_Transform_TopMenu1_Data(), (Button)sender);
        }

        private void button_DataValidateMenu_Click(object sender, EventArgs e)
        {
            MenuUserControlSwitch(new UserControl2_Transform_TopMenu2_Validate(), (Button)sender);
        }

        private void MenuUserControlSwitch(UserControl newUserConrol, Button currentButton)
        {
            button_ColumnMenu.BackColor = Color.LightGray;
            button_DataTransferMenu.BackColor = Color.LightGray;
            button_DataValidateMenu.BackColor = Color.LightGray;

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
        //UserControl2Transform_LeftMenu1ColumnInfo
        private void dataGridView1_ColumnHeaderCellChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            StagingObject stagingObject = StagingArea.TransformStObject;
            var attribut = stagingObject.Attributes.Where(x => x.Name == dataGridView1.Columns[e.ColumnIndex].Name).First();
            var newUserControl = new UserControl2_Transform_LeftMenu0_ColumnInfo(attribut);

            activeLeftMenuUserControl?.Dispose();
            activeLeftMenuUserControl = newUserControl;
            activeLeftMenuUserControl.Dock = DockStyle.Fill;
            activeLeftMenuUserControl.Parent = panel4;
        }

        public void ReCreateAndValidate()
        {
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);
        }
    }
}
