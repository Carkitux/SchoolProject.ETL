using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses.Serializer;
using SchoolProject.ETL.UI.WinFormsApp.Helper;
using SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    // Stellt den Inhalt des "Extract" Reiters des Hauptmenüs dar
    public partial class UC1Extract : UserControl
    {
        public UC1Extract()
        {
            InitializeComponent();

            ReCreateAndValidate();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            // Öffnet den Windows Dialog um eine Datei auszuwählen.
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();

            // Validate gegebenfalls mit UserFeedback
            if (openFileDialog1.FileName == string.Empty)
            {
                return;
            }
            foreach (TabPage tabpage in tabControl1.TabPages)
            {
                if (tabpage.Text == openFileDialog1.SafeFileName)
                {
                    MessageBox.Show("Eine Datei mit diesem Namen wurde bereits geladen.");
                    return;
                }
            }

            // Splittet die Endung/den Dateityp vom Namen der ausgewählten Datei
            var filePath = openFileDialog1.SafeFileName.Split('.');
            var fileTyp = filePath[^1];

            // Switch zum ausführen der jeweiligen Import Methode je nach Dateityp
            switch (fileTyp)
            {
                case "csv":
                    // Öffnet im Falle einer CSV Datei ein DialogFenster für die Einstellungen CSV Imports
                    using (var formDialog = new FormDialogCSVImport())
                    {
                        formDialog.FileName = openFileDialog1.FileName;
                        if (formDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            CSV.LoadFromCSV(openFileDialog1.FileName, formDialog.Seperator, formDialog.HasHeader);
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;
                case "json":
                    JSON.LoadFromJson(openFileDialog1.FileName);
                    break;
                case "xml":
                    XML.LoadFromXmlFile(openFileDialog1.FileName);
                    break;
                default:
                    MessageBox.Show("Bitte eine Datei vom Typ .csv, .json oder .xml auswählen.");
                    return;
            }

            ReCreateAndValidate();
        }

        private void button_ImportDelete_Click(object sender, EventArgs e)
        {
            StagingObject stagingObject = StagingArea.StObjects.Where(x => x.Name == tabControl1.SelectedTab.Text).FirstOrDefault();

            // Validiate
            if (stagingObject.Attributes.Where(x => x.TransferredTo.Count >= 1).Count() >= 1)
            {
                MessageBox.Show("Von dieser Tabelle wurden bereits Daten transformiert.");
                return;
            }

            // Löscht den aktiven Tab und dessen zugeordnetes stagingObject
            StagingArea.StObjects.Remove(stagingObject);
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            ReCreateAndValidate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TabPage page = tabControl1.SelectedTab;
            //DataGridView datagridView = (DataGridView)page.Controls[0];
            //toolStripStatusCountRows.Text = $"Anzahl Zeilen: {datagridView.Rows.Count}";
        }

        private void ReCreateAndValidate()
        {
            // Erstellt die Page und das dazugehörige DataGridView und befüllt dieses
            foreach (var stagingObject in StagingArea.StObjects)
            {
                if (TabPageHelper.ExistsInTabControl(stagingObject.Name, tabControl1))
                {
                    continue;
                }

                var tabPage = TabPageHelper.Create(stagingObject.Name, tabControl1);
                var dataGridView = DataGridViewHelper.Create(tabPage);
                DataGridViewHelper.UpdateData(dataGridView, stagingObject);
            }

            // Validiert den Status des Import Delete Buttons
            button_ImportDelete.Enabled = (tabControl1.TabPages.Count == 0)
                ? false
                : true;
        }
    }
}