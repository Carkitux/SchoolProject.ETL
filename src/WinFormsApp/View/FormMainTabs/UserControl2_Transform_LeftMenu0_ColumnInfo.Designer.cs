namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UserControl2_Transform_LeftMenu0_ColumnInfo
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
            textBoxAttributName = new System.Windows.Forms.TextBox();
            comboBoxDatatyp = new System.Windows.Forms.ComboBox();
            buttonChange = new System.Windows.Forms.Button();
            labelAttributName = new System.Windows.Forms.Label();
            labelDatatyp = new System.Windows.Forms.Label();
            labelDataSourceStjObj = new System.Windows.Forms.Label();
            listBoxDataSourceStjObj = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // textBoxAttributName
            // 
            textBoxAttributName.Dock = System.Windows.Forms.DockStyle.Top;
            textBoxAttributName.Location = new System.Drawing.Point(0, 15);
            textBoxAttributName.Name = "textBoxAttributName";
            textBoxAttributName.Size = new System.Drawing.Size(150, 23);
            textBoxAttributName.TabIndex = 0;
            textBoxAttributName.Text = "Spaltenname";
            // 
            // comboBoxDatatyp
            // 
            comboBoxDatatyp.Dock = System.Windows.Forms.DockStyle.Top;
            comboBoxDatatyp.FormattingEnabled = true;
            comboBoxDatatyp.Location = new System.Drawing.Point(0, 53);
            comboBoxDatatyp.Name = "comboBoxDatatyp";
            comboBoxDatatyp.Size = new System.Drawing.Size(150, 23);
            comboBoxDatatyp.TabIndex = 1;
            comboBoxDatatyp.Text = "Datentyp";
            // 
            // buttonChange
            // 
            buttonChange.Dock = System.Windows.Forms.DockStyle.Top;
            buttonChange.Location = new System.Drawing.Point(0, 76);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new System.Drawing.Size(150, 23);
            buttonChange.TabIndex = 2;
            buttonChange.Text = "Ändern";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // labelAttributName
            // 
            labelAttributName.AutoSize = true;
            labelAttributName.Dock = System.Windows.Forms.DockStyle.Top;
            labelAttributName.Location = new System.Drawing.Point(0, 0);
            labelAttributName.Name = "labelAttributName";
            labelAttributName.Size = new System.Drawing.Size(76, 15);
            labelAttributName.TabIndex = 3;
            labelAttributName.Text = "Spaltenname";
            // 
            // labelDatatyp
            // 
            labelDatatyp.AutoSize = true;
            labelDatatyp.Dock = System.Windows.Forms.DockStyle.Top;
            labelDatatyp.Location = new System.Drawing.Point(0, 38);
            labelDatatyp.Name = "labelDatatyp";
            labelDatatyp.Size = new System.Drawing.Size(55, 15);
            labelDatatyp.TabIndex = 4;
            labelDatatyp.Text = "Datentyp";
            // 
            // labelDataSourceStjObj
            // 
            labelDataSourceStjObj.AutoSize = true;
            labelDataSourceStjObj.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelDataSourceStjObj.Location = new System.Drawing.Point(0, 187);
            labelDataSourceStjObj.Name = "labelDataSourceStjObj";
            labelDataSourceStjObj.Size = new System.Drawing.Size(133, 15);
            labelDataSourceStjObj.TabIndex = 5;
            labelDataSourceStjObj.Text = "Daten von Quellspalten:";
            // 
            // listBoxDataSourceStjObj
            // 
            listBoxDataSourceStjObj.Dock = System.Windows.Forms.DockStyle.Bottom;
            listBoxDataSourceStjObj.FormattingEnabled = true;
            listBoxDataSourceStjObj.ItemHeight = 15;
            listBoxDataSourceStjObj.Location = new System.Drawing.Point(0, 202);
            listBoxDataSourceStjObj.Name = "listBoxDataSourceStjObj";
            listBoxDataSourceStjObj.Size = new System.Drawing.Size(150, 274);
            listBoxDataSourceStjObj.TabIndex = 6;
            // 
            // UserControl2_Transform_LeftMenu0_ColumnInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(labelDataSourceStjObj);
            Controls.Add(buttonChange);
            Controls.Add(comboBoxDatatyp);
            Controls.Add(listBoxDataSourceStjObj);
            Controls.Add(labelDatatyp);
            Controls.Add(textBoxAttributName);
            Controls.Add(labelAttributName);
            Name = "UserControl2_Transform_LeftMenu0_ColumnInfo";
            Size = new System.Drawing.Size(150, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAttributName;
        private System.Windows.Forms.ComboBox comboBoxDatatyp;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelAttributName;
        private System.Windows.Forms.Label labelDatatyp;
        private System.Windows.Forms.Label labelDataSourceStjObj;
        private System.Windows.Forms.ListBox listBoxDataSourceStjObj;
    }
}
