namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UC2Transform_UCTopData
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
            button_AutomaticTransfer = new System.Windows.Forms.Button();
            button_DataTransfer = new System.Windows.Forms.Button();
            button_DataMerge = new System.Windows.Forms.Button();
            button_DataSplit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_AutomaticTransfer
            // 
            button_AutomaticTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            button_AutomaticTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            button_AutomaticTransfer.FlatAppearance.BorderSize = 0;
            button_AutomaticTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_AutomaticTransfer.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_AutomaticTransfer.Location = new System.Drawing.Point(0, 0);
            button_AutomaticTransfer.Name = "button_AutomaticTransfer";
            button_AutomaticTransfer.Size = new System.Drawing.Size(127, 49);
            button_AutomaticTransfer.TabIndex = 5;
            button_AutomaticTransfer.Text = "Autom.\r\nTransfer";
            button_AutomaticTransfer.UseVisualStyleBackColor = false;
            button_AutomaticTransfer.Click += button_DataTransferAutomatic_Click;
            // 
            // button_DataTransfer
            // 
            button_DataTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataTransfer.FlatAppearance.BorderSize = 0;
            button_DataTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataTransfer.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataTransfer.Location = new System.Drawing.Point(127, 0);
            button_DataTransfer.Name = "button_DataTransfer";
            button_DataTransfer.Size = new System.Drawing.Size(127, 49);
            button_DataTransfer.TabIndex = 6;
            button_DataTransfer.Text = "Transfer";
            button_DataTransfer.UseVisualStyleBackColor = false;
            button_DataTransfer.Click += button_DataTransferManual_Click;
            // 
            // button_DataMerge
            // 
            button_DataMerge.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataMerge.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataMerge.FlatAppearance.BorderSize = 0;
            button_DataMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataMerge.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataMerge.Location = new System.Drawing.Point(254, 0);
            button_DataMerge.Name = "button_DataMerge";
            button_DataMerge.Size = new System.Drawing.Size(127, 49);
            button_DataMerge.TabIndex = 7;
            button_DataMerge.Text = "Merge";
            button_DataMerge.UseVisualStyleBackColor = false;
            button_DataMerge.Click += button1_Click;
            // 
            // button_DataSplit
            // 
            button_DataSplit.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataSplit.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataSplit.FlatAppearance.BorderSize = 0;
            button_DataSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataSplit.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataSplit.Location = new System.Drawing.Point(381, 0);
            button_DataSplit.Name = "button_DataSplit";
            button_DataSplit.Size = new System.Drawing.Size(127, 49);
            button_DataSplit.TabIndex = 8;
            button_DataSplit.Text = "Split";
            button_DataSplit.UseVisualStyleBackColor = false;
            // 
            // UC2Transform_UCTopData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(button_DataSplit);
            Controls.Add(button_DataMerge);
            Controls.Add(button_DataTransfer);
            Controls.Add(button_AutomaticTransfer);
            Name = "UC2Transform_UCTopData";
            Size = new System.Drawing.Size(709, 49);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_AutomaticTransfer;
        private System.Windows.Forms.Button button_DataTransfer;
        private System.Windows.Forms.Button button_DataMerge;
        private System.Windows.Forms.Button button_DataSplit;
    }
}
