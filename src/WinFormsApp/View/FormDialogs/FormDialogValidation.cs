using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.LogicClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogValidation : Form
    {
        public FormDialogValidation(DataRowCell cell, int count)
        {
            InitializeComponent();

            this.cell = cell;

            textBox_SourceFileName.Text = cell.DataRow.SourceFileName;
            textBox_ColumnName.Text = cell.Attribut.Name;
            textBox_Datatyp.Text = cell.Attribut.Datatyp.ToString();
            textBox_Value.Text = cell.Value;
            Text = $"{count} verbleibende Validierungsfehler";

            label_ErrorMessage.Text =
                $"\"{cell.Value}\" ist kein gültiger Inhalt für den Dateityp \"{cell.Attribut.Datatyp}\"";
            textBox_Value.BackColor = Color.LightPink;
        }

        DataRowCell cell;

        private void button_Validate_Click(object sender, EventArgs e)
        {
            if (textBox_Value.Text == string.Empty)
            {
                label_ErrorMessage.Text =
                    $"Der Inhalt wird gelöscht.";
                textBox_Value.BackColor = Color.LightGreen;
            }
            else if (!Validation.ValidateSingle(cell, textBox_Value.Text))
            {
                label_ErrorMessage.Text =
                    $"\"{cell.Value}\" ist kein gültiger Inhalt für den Dateityp \"{cell.Attribut.Datatyp}\".";
                textBox_Value.BackColor = Color.LightPink;
            }
            else
            {
                label_ErrorMessage.Text =
                    $"Der Inhalt ist gültig.";
                textBox_Value.BackColor = Color.LightGreen;
            }
        }

        private void button_Ignore_Click(object sender, EventArgs e)
        {
            cell.ValidationStatus = Model.Enums.ValidationStatus.Ignore;
            DialogResult = DialogResult.OK;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (textBox_Value.Text == string.Empty)
            {
                cell.ValidationStatus = ValidationStatus.Valid;
                DialogResult = DialogResult.OK;
            }
            else if (Validation.ValidateSingle(cell, textBox_Value.Text))
            {
                cell.ValidationStatus = ValidationStatus.Valid;
                DialogResult = DialogResult.OK;
            }

            button_Validate_Click(null, null);
        }
    }
}
