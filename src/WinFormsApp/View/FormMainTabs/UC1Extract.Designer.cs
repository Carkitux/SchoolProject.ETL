namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UC1Extract
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
            button_Import = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            button_ImportDelete = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_Import
            // 
            button_Import.Dock = System.Windows.Forms.DockStyle.Left;
            button_Import.FlatAppearance.BorderSize = 0;
            button_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Import.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_Import.Location = new System.Drawing.Point(0, 0);
            button_Import.Name = "button_Import";
            button_Import.Size = new System.Drawing.Size(127, 49);
            button_Import.TabIndex = 1;
            button_Import.Text = "Import";
            button_Import.UseVisualStyleBackColor = true;
            button_Import.Click += button_import_Click;
            // 
            // tabControl1
            // 
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(782, 446);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(button_ImportDelete);
            panel1.Controls.Add(button_Import);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(782, 49);
            panel1.TabIndex = 1;
            // 
            // button_ImportDelete
            // 
            button_ImportDelete.Dock = System.Windows.Forms.DockStyle.Left;
            button_ImportDelete.FlatAppearance.BorderSize = 0;
            button_ImportDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ImportDelete.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ImportDelete.Location = new System.Drawing.Point(127, 0);
            button_ImportDelete.Name = "button_ImportDelete";
            button_ImportDelete.Size = new System.Drawing.Size(127, 49);
            button_ImportDelete.TabIndex = 2;
            button_ImportDelete.Text = "Import\r\nlöschen";
            button_ImportDelete.UseVisualStyleBackColor = true;
            button_ImportDelete.Click += button_ImportDelete_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 49);
            panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(782, 446);
            panel2.TabIndex = 2;
            // 
            // UC1Extract
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC1Extract";
            Size = new System.Drawing.Size(782, 495);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ImportDelete;
    }
}
