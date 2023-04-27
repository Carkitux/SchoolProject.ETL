using SchoolProject.ETL.Logger;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    // Stellt den Inhalt des "Logging" Reiters des Hauptmenüs dar
    public partial class UserControl4Log : UserControl
    {
        public UserControl4Log()
        {
            InitializeComponent();
        }

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

            // Befüllt beim Laden des UserControls die StatusStripLabels mit allen Log Informationen
            toolStripStatusLabelPreviewRowCount.Text = $"Preview Zeilen Anzahl: {textBoxLog.Lines.Count()} (max. 1000)";
            toolStripStatusLabelCurrentLogSize.Text = $"Loggröße: {LogWriter.FileSizeMBCurrent} mb";
            toolStripStatusLabelLogFileCount.Text = $"Alle Logs Anzahl: {LogWriter.FileCount}";
            toolStripStatusLabelLogFileSizeSum.Text = $"Alle Logs Größe: {LogWriter.FileSizeMBAll} mb";
        }
    }
}
