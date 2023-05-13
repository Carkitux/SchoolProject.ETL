using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.LogicClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogColumnAddEdit : Form
    {
        public FormDialogColumnAddEdit(string modus, string selectedAttributeName)
        {
            InitializeComponent();

            this.modus = modus;
            this.oldAttributeName = selectedAttributeName;
            var oldAttribute = StagingArea.TransformStObject.GetAttribut(selectedAttributeName);

            if (modus == "Edit")
            {
                Text = "Spalte bearbeiten";
                textBox1.Text = oldAttribute.Name;
                comboBox1.SelectedItem = oldAttribute.Datatyp;
                numericUpDown1.Value = oldAttribute.MaxLength;
            }
            numericUpDown1.DecimalPlaces = 0;

            StagingArea.TransformStObject.Attributes.ForEach(a => { currentAttributes.Add(a.Name); });
            comboBox1.DataSource = Enum.GetValues(typeof(Datatyp));
        }

        private string modus;
        private string oldAttributeName;
        private List<string> currentAttributes = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            var columnName = textBox1.Text;
            var maxLength = (int)numericUpDown1.Value;
            var datatyp = comboBox1.SelectedItem is null
                ? Datatyp.unknown
                : (Datatyp)comboBox1.SelectedItem;

            if (columnName == string.Empty)
            {
                MessageBox.Show("Bitte einen Spaltennamen angeben.");
                return;
            }

            if (modus == "Add")
            {
                if (currentAttributes.Contains(columnName))
                {
                    MessageBox.Show("Dieser Spaltenname ist bereits vorhanden.");
                    return;
                }

                Transform.CreateAttribut(columnName, datatyp);
            }
            else if (modus == "Edit")
            {
                if (currentAttributes.Contains(columnName) && columnName != oldAttributeName)
                {
                    MessageBox.Show("Dieser Spaltenname ist bereits vorhanden.");
                    return;
                }

                var attribut = StagingArea.TransformStObject.GetAttribut(oldAttributeName);
                attribut.Edit(columnName, datatyp, maxLength);
            }

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
