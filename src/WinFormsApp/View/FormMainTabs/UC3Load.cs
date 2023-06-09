﻿using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses.Serializer;
using SchoolProject.ETL.UI.WinFormsApp.Helper;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    public partial class UC3Load : UserControl
    {
        public UC3Load()
        {
            InitializeComponent();

            comboBox_Export.Items.Add("json");
            comboBox_Export.Items.Add("csv");
            comboBox_Export.Items.Add("xml");

            Refresh();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (comboBox_Export.SelectedItem == null)
            {
                MessageBox.Show("Bitte einen Dateityp in der Combobox auswählen.");
                return;
            }

            saveFileDialog1.Filter = $"{comboBox_Export.SelectedItem} | *.{comboBox_Export.SelectedItem}";
            saveFileDialog1.FileName = string.Empty;

            if (!(saveFileDialog1.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            switch (comboBox_Export.SelectedItem)
            {
                case "json":
                    JSON.CreateJSON(saveFileDialog1.FileName);
                    break;
                case "csv":
                    CSV.CreateCSV(saveFileDialog1.FileName);
                    break;
                case "xml":
                    XML.CreateXML(saveFileDialog1.FileName);
                    break;
                default:
                    break;
            }

            string[] fileNameSplit = saveFileDialog1.FileName.Split('\\');
            string path = string.Empty;
            foreach (var item in fileNameSplit.Reverse().Skip(1).Reverse())
            {
                path = path + item + "\\";
            }
            Process.Start("explorer.exe", path);

            int countSourceFiles = 0;
            float fileSizeSourceFiles = 0;
            foreach (var item in StagingArea.StObjects)
            {
                fileSizeSourceFiles += item.FileSizeMB;
                countSourceFiles++;
            }

            MessageBox.Show($"{countSourceFiles} Quelldateien mit einer Gesamtgröße von {fileSizeSourceFiles} MB " +
                $"wurden in eine Größe von {StagingArea.TransformStObject.FileSizeMB} MB transformiert.");
        }

        public override void Refresh()
        {
            base.Refresh();

            // Erstellt eine Tabelle die im neu erstellten Reiter angedockt wird
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

            // Erstellt die Spalten und befüllt die Tabelle
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStObject);
        }
    }
}
