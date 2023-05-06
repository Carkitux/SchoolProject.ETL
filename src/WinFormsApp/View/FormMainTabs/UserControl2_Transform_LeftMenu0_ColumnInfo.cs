using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform_LeftMenu0_ColumnInfo : UserControl
    {
        Attribut selectedAttribut;

        public UserControl2_Transform_LeftMenu0_ColumnInfo(Attribut attribut)
        {
            InitializeComponent();

            selectedAttribut = attribut;

            comboBoxDatatyp.DataSource = Enum.GetValues(typeof(Datatyp));

            var selectedTransformAttribut = attribut.Datatyp.ToString();

            textBoxAttributName.Text = attribut.Name;
            comboBoxDatatyp.SelectedText = attribut.Datatyp.ToString();
            listBoxDataSourceStjObj.Items.Clear();

            ReCreateAndValidate();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        public void ReCreateAndValidate()
        {
            listBoxDataSourceStjObj.Items.Clear();

            foreach (var attribut in StagingArea.TransformStObject.Attributes.Where(x => x == selectedAttribut).First().TransferredFrom)
            {
                listBoxDataSourceStjObj.Items.Add(attribut);
            }
        }
    }
}
