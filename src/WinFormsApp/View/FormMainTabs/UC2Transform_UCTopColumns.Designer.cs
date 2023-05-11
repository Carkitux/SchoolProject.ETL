namespace SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs
{
    partial class UC2Transform_UCTopColumns
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
            button_ColumnAdd = new System.Windows.Forms.Button();
            button_ColumnEdit = new System.Windows.Forms.Button();
            button_ColumnDelete = new System.Windows.Forms.Button();
            button_ColumnGenerate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_ColumnAdd
            // 
            button_ColumnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            button_ColumnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            button_ColumnAdd.FlatAppearance.BorderSize = 0;
            button_ColumnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ColumnAdd.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ColumnAdd.Location = new System.Drawing.Point(127, 0);
            button_ColumnAdd.Name = "button_ColumnAdd";
            button_ColumnAdd.Size = new System.Drawing.Size(127, 49);
            button_ColumnAdd.TabIndex = 1;
            button_ColumnAdd.Text = "Spalte hinzufügen";
            button_ColumnAdd.UseVisualStyleBackColor = false;
            button_ColumnAdd.Click += button_ColumnAdd_Click;
            // 
            // button_ColumnEdit
            // 
            button_ColumnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            button_ColumnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            button_ColumnEdit.FlatAppearance.BorderSize = 0;
            button_ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ColumnEdit.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ColumnEdit.Location = new System.Drawing.Point(254, 0);
            button_ColumnEdit.Name = "button_ColumnEdit";
            button_ColumnEdit.Size = new System.Drawing.Size(127, 49);
            button_ColumnEdit.TabIndex = 2;
            button_ColumnEdit.Text = "Spalte bearbeiten";
            button_ColumnEdit.UseVisualStyleBackColor = false;
            button_ColumnEdit.Click += button_ColumnEdit_Click;
            // 
            // button_ColumnDelete
            // 
            button_ColumnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            button_ColumnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            button_ColumnDelete.FlatAppearance.BorderSize = 0;
            button_ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ColumnDelete.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ColumnDelete.Location = new System.Drawing.Point(381, 0);
            button_ColumnDelete.Name = "button_ColumnDelete";
            button_ColumnDelete.Size = new System.Drawing.Size(127, 49);
            button_ColumnDelete.TabIndex = 3;
            button_ColumnDelete.Text = "Spalte\r\nlöschen";
            button_ColumnDelete.UseVisualStyleBackColor = false;
            button_ColumnDelete.Click += button_ColumnDelete_Click;
            // 
            // button_ColumnGenerate
            // 
            button_ColumnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            button_ColumnGenerate.Dock = System.Windows.Forms.DockStyle.Left;
            button_ColumnGenerate.FlatAppearance.BorderSize = 0;
            button_ColumnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ColumnGenerate.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ColumnGenerate.Location = new System.Drawing.Point(0, 0);
            button_ColumnGenerate.Name = "button_ColumnGenerate";
            button_ColumnGenerate.Size = new System.Drawing.Size(127, 49);
            button_ColumnGenerate.TabIndex = 4;
            button_ColumnGenerate.Text = "Spalten\r\ngenerieren";
            button_ColumnGenerate.UseVisualStyleBackColor = false;
            button_ColumnGenerate.Click += button_ColumnGenerate_Click;
            // 
            // UserControl2_Transform_TopMenu0_Columns
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(button_ColumnDelete);
            Controls.Add(button_ColumnEdit);
            Controls.Add(button_ColumnAdd);
            Controls.Add(button_ColumnGenerate);
            Name = "UserControl2_Transform_TopMenu0_Columns";
            Size = new System.Drawing.Size(709, 49);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_ColumnAdd;
        private System.Windows.Forms.Button button_ColumnEdit;
        private System.Windows.Forms.Button button_ColumnDelete;
        private System.Windows.Forms.Button button_ColumnGenerate;
    }
}
