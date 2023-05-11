namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UC4Log
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLog = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            labelLoglevel = new System.Windows.Forms.Label();
            comboBoxLoglevel = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            buttonLogOeffnen = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelPreviewRowCount = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelCurrentLogSize = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelLogFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelLogFileSizeSum = new System.Windows.Forms.ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxLog.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLog.Location = new System.Drawing.Point(0, 0);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxLog.Size = new System.Drawing.Size(727, 322);
            textBoxLog.TabIndex = 0;
            textBoxLog.WordWrap = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(labelLoglevel);
            panel1.Controls.Add(comboBoxLoglevel);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonLogOeffnen);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(727, 49);
            panel1.TabIndex = 1;
            // 
            // labelLoglevel
            // 
            labelLoglevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelLoglevel.AutoSize = true;
            labelLoglevel.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoglevel.Location = new System.Drawing.Point(545, 2);
            labelLoglevel.Name = "labelLoglevel";
            labelLoglevel.Size = new System.Drawing.Size(112, 15);
            labelLoglevel.TabIndex = 4;
            labelLoglevel.Text = "Minimum Loglevel";
            // 
            // comboBoxLoglevel
            // 
            comboBoxLoglevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            comboBoxLoglevel.FormattingEnabled = true;
            comboBoxLoglevel.Location = new System.Drawing.Point(545, 20);
            comboBoxLoglevel.Name = "comboBoxLoglevel";
            comboBoxLoglevel.Size = new System.Drawing.Size(170, 23);
            comboBoxLoglevel.TabIndex = 3;
            comboBoxLoglevel.Text = "default";
            comboBoxLoglevel.SelectedIndexChanged += comboBoxLoglevel_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(127, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(127, 49);
            button2.TabIndex = 1;
            button2.Text = "Dateipfad öffnen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonLogOeffnen
            // 
            buttonLogOeffnen.Dock = System.Windows.Forms.DockStyle.Left;
            buttonLogOeffnen.FlatAppearance.BorderSize = 0;
            buttonLogOeffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogOeffnen.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonLogOeffnen.Location = new System.Drawing.Point(0, 0);
            buttonLogOeffnen.Name = "buttonLogOeffnen";
            buttonLogOeffnen.Size = new System.Drawing.Size(127, 49);
            buttonLogOeffnen.TabIndex = 0;
            buttonLogOeffnen.Text = "Log öffnen";
            buttonLogOeffnen.UseVisualStyleBackColor = true;
            buttonLogOeffnen.Click += buttonLogOeffnen_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxLog);
            panel2.Controls.Add(statusStrip1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(727, 346);
            panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelPreviewRowCount, toolStripStatusLabelCurrentLogSize, toolStripStatusLabel1, toolStripStatusLabelLogFileCount, toolStripStatusLabelLogFileSizeSum });
            statusStrip1.Location = new System.Drawing.Point(0, 322);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(727, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPreviewRowCount
            // 
            toolStripStatusLabelPreviewRowCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabelPreviewRowCount.Name = "toolStripStatusLabelPreviewRowCount";
            toolStripStatusLabelPreviewRowCount.Size = new System.Drawing.Size(193, 19);
            toolStripStatusLabelPreviewRowCount.Text = "Preview Zeilen Anzahl: (max. 1000)";
            // 
            // toolStripStatusLabelCurrentLogSize
            // 
            toolStripStatusLabelCurrentLogSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabelCurrentLogSize.Name = "toolStripStatusLabelCurrentLogSize";
            toolStripStatusLabelCurrentLogSize.Size = new System.Drawing.Size(68, 19);
            toolStripStatusLabelCurrentLogSize.Text = "Loggröße: ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(212, 19);
            toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabelLogFileCount
            // 
            toolStripStatusLabelLogFileCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabelLogFileCount.Name = "toolStripStatusLabelLogFileCount";
            toolStripStatusLabelLogFileCount.Size = new System.Drawing.Size(102, 19);
            toolStripStatusLabelLogFileCount.Text = "Logdatei Anzahl: ";
            // 
            // toolStripStatusLabelLogFileSizeSum
            // 
            toolStripStatusLabelLogFileSizeSum.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabelLogFileSizeSum.Name = "toolStripStatusLabelLogFileSizeSum";
            toolStripStatusLabelLogFileSizeSum.Size = new System.Drawing.Size(137, 19);
            toolStripStatusLabelLogFileSizeSum.Text = "Gesamtgröße alle Logs: ";
            // 
            // UserControl4Log
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl4Log";
            Size = new System.Drawing.Size(727, 395);
            Load += UserControl4_Log_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOeffnen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPreviewRowCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentLogSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileSizeSum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelLoglevel;
        private System.Windows.Forms.ComboBox comboBoxLoglevel;
    }
}
