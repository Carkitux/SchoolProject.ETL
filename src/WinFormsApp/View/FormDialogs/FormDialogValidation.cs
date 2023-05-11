using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogValidation : Form
    {
        public FormDialogValidation(DataRowCell cell)
        {
            InitializeComponent();

            this.cell = cell;

            textBox_SourceFileName.Text = cell.DataRow.SourceFileName;
            textBox_ColumnName.Text = cell.Attribut.Name;
            textBox_Datatyp.Text = cell.Attribut.Datatyp.ToString();
            textBox_Value.Text = cell.Value;

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
            else if (!Validation.ValidateEMail(cell, textBox_Value.Text))
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
                DialogResult = DialogResult.OK;
            }
            else if (!Validation.ValidateEMail(cell, textBox_Value.Text))
            {
                DialogResult = DialogResult.OK;
            }

            button_Validate_Click(null, null);
        }
    }
}
