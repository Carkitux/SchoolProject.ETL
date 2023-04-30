namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UserControl2_Transform_TopMenu1_Data
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
            button_DataTransferAutomatic = new System.Windows.Forms.Button();
            button_DataTransferManual = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_DataTransferAutomatic
            // 
            button_DataTransferAutomatic.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataTransferAutomatic.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataTransferAutomatic.FlatAppearance.BorderSize = 0;
            button_DataTransferAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataTransferAutomatic.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataTransferAutomatic.Location = new System.Drawing.Point(0, 0);
            button_DataTransferAutomatic.Name = "button_DataTransferAutomatic";
            button_DataTransferAutomatic.Size = new System.Drawing.Size(127, 49);
            button_DataTransferAutomatic.TabIndex = 5;
            button_DataTransferAutomatic.Text = "Automatischer\r\nDatentransfer";
            button_DataTransferAutomatic.UseVisualStyleBackColor = false;
            button_DataTransferAutomatic.Click += button_DataTransferAutomatic_Click;
            // 
            // button_DataTransferManual
            // 
            button_DataTransferManual.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataTransferManual.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataTransferManual.FlatAppearance.BorderSize = 0;
            button_DataTransferManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataTransferManual.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataTransferManual.Location = new System.Drawing.Point(127, 0);
            button_DataTransferManual.Name = "button_DataTransferManual";
            button_DataTransferManual.Size = new System.Drawing.Size(127, 49);
            button_DataTransferManual.TabIndex = 6;
            button_DataTransferManual.Text = "Manueller\r\nDatentransfer";
            button_DataTransferManual.UseVisualStyleBackColor = false;
            button_DataTransferManual.Click += button_DataTransferManual_Click;
            // 
            // UserControl2_Transform_TopMenu1_Data
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(button_DataTransferManual);
            Controls.Add(button_DataTransferAutomatic);
            Name = "UserControl2_Transform_TopMenu1_Data";
            Size = new System.Drawing.Size(709, 49);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_DataTransferAutomatic;
        private System.Windows.Forms.Button button_DataTransferManual;
    }
}
