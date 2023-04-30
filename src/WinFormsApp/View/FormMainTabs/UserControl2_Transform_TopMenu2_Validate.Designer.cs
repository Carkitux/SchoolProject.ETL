namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UserControl2_Transform_TopMenu2_Validate
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
            button_DataValidate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_DataValidate
            // 
            button_DataValidate.BackColor = System.Drawing.Color.WhiteSmoke;
            button_DataValidate.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataValidate.FlatAppearance.BorderSize = 0;
            button_DataValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataValidate.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataValidate.Location = new System.Drawing.Point(0, 0);
            button_DataValidate.Name = "button_DataValidate";
            button_DataValidate.Size = new System.Drawing.Size(127, 49);
            button_DataValidate.TabIndex = 5;
            button_DataValidate.Text = "Validiere\r\nDaten";
            button_DataValidate.UseVisualStyleBackColor = false;
            button_DataValidate.Click += button_DataValidate_Click;
            // 
            // UserControl2_Transform_TopMenu2_Validate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(button_DataValidate);
            Name = "UserControl2_Transform_TopMenu2_Validate";
            Size = new System.Drawing.Size(709, 49);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_DataValidate;
    }
}
