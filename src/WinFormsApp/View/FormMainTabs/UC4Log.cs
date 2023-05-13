using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    // Stellt den Inhalt des "Logging" Reiters des Hauptmenüs dar
    public partial class UC4Log : UserControl
    {
        public UC4Log()
        {
            InitializeComponent();

            comboBoxLoglevel.DataSource = Enum.GetValues(typeof(Loglevel));
            SkipComboBoxLogLevel = true;
            comboBoxLoglevel.Text = LogWriter.applicationLoglevelString;
            SkipComboBoxLogLevel = false;
        }

        private bool SkipComboBoxLogLevel = true;

        private void buttonLogOeffnen_Click(object sender, EventArgs e)
        {
            //Validate
            if (!File.Exists(LogWriter.filePath))
                return;

            // Öffnet das aktuelle Log mit dem als in Windows als Standard hinterlegten Programm
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + LogWriter.filePath + "\"";
            fileopener.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate
            if (!Directory.Exists(LogWriter.logPath))
                return;

            // Öffnet den Dateipfad innehralb des Windows Dateiexplorers
            Process.Start("explorer.exe", LogWriter.logPath);
        }

        private void UserControl4_Log_Load(object sender, EventArgs e)
        {
            // Befüllt beim Laden des UserControls die TextBox mit den letzten 1000 Zeilen und scrollt nach ganz unten
            textBoxLog.Text = LogWriter.GetLastLines(1000);
            textBoxLog.Focus();
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.ScrollToCaret();
        }

        private void comboBoxLoglevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkipComboBoxLogLevel)
            {
                return;
            }
            LogWriter.SetLoglevelConfig(comboBoxLoglevel.Text);
        }
    }
}
