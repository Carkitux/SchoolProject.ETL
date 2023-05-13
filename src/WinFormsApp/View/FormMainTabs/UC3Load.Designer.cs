namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UC3Load
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
            comboBox_Export = new System.Windows.Forms.ComboBox();
            button_Export = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_Export
            // 
            comboBox_Export.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comboBox_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox_Export.FormattingEnabled = true;
            comboBox_Export.Location = new System.Drawing.Point(133, 14);
            comboBox_Export.Name = "comboBox_Export";
            comboBox_Export.Size = new System.Drawing.Size(127, 23);
            comboBox_Export.TabIndex = 1;
            comboBox_Export.Text = "Zielformat";
            // 
            // button_Export
            // 
            button_Export.Dock = System.Windows.Forms.DockStyle.Left;
            button_Export.FlatAppearance.BorderSize = 0;
            button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Export.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_Export.Location = new System.Drawing.Point(0, 0);
            button_Export.Name = "button_Export";
            button_Export.Size = new System.Drawing.Size(127, 49);
            button_Export.TabIndex = 0;
            button_Export.Text = "Export";
            button_Export.UseVisualStyleBackColor = true;
            button_Export.Click += button_Export_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(800, 551);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(comboBox_Export);
            panel1.Controls.Add(button_Export);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 49);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 551);
            panel2.TabIndex = 2;
            // 
            // UC3Load
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC3Load";
            Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Export;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
