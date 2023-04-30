using SchoolProject.ETL.Model.DataClasses.StagingObjectAgr;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UserControl2_Transform_LeftMenu0_ColumnInfo : UserControl
    {
        public UserControl2_Transform_LeftMenu0_ColumnInfo(Attribut attribut)
        {
            InitializeComponent();

            comboBoxDatatyp.DataSource = Enum.GetValues(typeof(Datatyp));

            var selectedTransformAttribut = attribut.Datatyp.ToString();

            textBoxAttributName.Text = attribut.Name;
            comboBoxDatatyp.SelectedText = attribut.Datatyp.ToString();
            listBoxDataSourceStjObj.Items.Clear();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }
    }
}
