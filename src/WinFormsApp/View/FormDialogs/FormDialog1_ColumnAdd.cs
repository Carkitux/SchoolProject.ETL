using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.LogicClasses.Transform;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class FormDialog1_ColumnAdd : Form
    {
        public FormDialog1_ColumnAdd()
        {
            InitializeComponent();

            // Initialisieren der FormDialog Felder
            Spaltennamen = new List<string>();
            comboBox1.DataSource = Enum.GetValues(typeof(Datatyp));
        }

        public List<string> Spaltennamen;
        public string Spaltenname;

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate
            Spaltenname = textBox1.Text;
            if (Spaltenname == string.Empty)
            {
                MessageBox.Show("Bitte einen Spaltennamen angeben.");
                return;
            }
            if (Spaltennamen.Contains(Spaltenname))
            {
                MessageBox.Show("Dieser Spaltenname ist bereits vorhanden.");
                return;
            }

            Datatyp datentyp = comboBox1.SelectedItem is null 
                ? Datatyp.Unknown
                : (Datatyp)comboBox1.SelectedItem;

            Transform.CreateAttribut(Spaltenname, datentyp);

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
