namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    partial class FormDialogValidation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_SourceFileName = new System.Windows.Forms.TextBox();
            label_ErrorMessage = new System.Windows.Forms.Label();
            textBox_ColumnName = new System.Windows.Forms.TextBox();
            button_Validate = new System.Windows.Forms.Button();
            button_Ignore = new System.Windows.Forms.Button();
            button_Next = new System.Windows.Forms.Button();
            textBox_Datatyp = new System.Windows.Forms.TextBox();
            textBox_Value = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox_SourceFileName
            // 
            textBox_SourceFileName.Enabled = false;
            textBox_SourceFileName.Location = new System.Drawing.Point(12, 12);
            textBox_SourceFileName.Name = "textBox_SourceFileName";
            textBox_SourceFileName.Size = new System.Drawing.Size(331, 23);
            textBox_SourceFileName.TabIndex = 0;
            textBox_SourceFileName.Text = "Quelldatei";
            // 
            // label_ErrorMessage
            // 
            label_ErrorMessage.AutoSize = true;
            label_ErrorMessage.Location = new System.Drawing.Point(12, 96);
            label_ErrorMessage.Name = "label_ErrorMessage";
            label_ErrorMessage.Size = new System.Drawing.Size(87, 15);
            label_ErrorMessage.TabIndex = 1;
            label_ErrorMessage.Text = "Fehlermeldung";
            // 
            // textBox_ColumnName
            // 
            textBox_ColumnName.Enabled = false;
            textBox_ColumnName.Location = new System.Drawing.Point(12, 41);
            textBox_ColumnName.Name = "textBox_ColumnName";
            textBox_ColumnName.Size = new System.Drawing.Size(331, 23);
            textBox_ColumnName.TabIndex = 2;
            textBox_ColumnName.Text = "Spalte";
            // 
            // button_Validate
            // 
            button_Validate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button_Validate.Location = new System.Drawing.Point(12, 154);
            button_Validate.Name = "button_Validate";
            button_Validate.Size = new System.Drawing.Size(75, 23);
            button_Validate.TabIndex = 3;
            button_Validate.Text = "Prüfen";
            button_Validate.UseVisualStyleBackColor = true;
            button_Validate.Click += button_Validate_Click;
            // 
            // button_Ignore
            // 
            button_Ignore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button_Ignore.Location = new System.Drawing.Point(173, 154);
            button_Ignore.Name = "button_Ignore";
            button_Ignore.Size = new System.Drawing.Size(89, 23);
            button_Ignore.TabIndex = 4;
            button_Ignore.Text = "Ignorieren";
            button_Ignore.UseVisualStyleBackColor = true;
            button_Ignore.Click += button_Ignore_Click;
            // 
            // button_Next
            // 
            button_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button_Next.Location = new System.Drawing.Point(268, 154);
            button_Next.Name = "button_Next";
            button_Next.Size = new System.Drawing.Size(75, 23);
            button_Next.TabIndex = 5;
            button_Next.Text = "Weiter";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += button_Next_Click;
            // 
            // textBox_Datatyp
            // 
            textBox_Datatyp.Enabled = false;
            textBox_Datatyp.Location = new System.Drawing.Point(12, 70);
            textBox_Datatyp.Name = "textBox_Datatyp";
            textBox_Datatyp.Size = new System.Drawing.Size(331, 23);
            textBox_Datatyp.TabIndex = 6;
            textBox_Datatyp.Text = "Dateityp";
            // 
            // textBox_Value
            // 
            textBox_Value.Location = new System.Drawing.Point(12, 114);
            textBox_Value.Name = "textBox_Value";
            textBox_Value.Size = new System.Drawing.Size(331, 23);
            textBox_Value.TabIndex = 7;
            textBox_Value.Text = "Inhalt";
            // 
            // FormDialogValidation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 189);
            Controls.Add(textBox_Value);
            Controls.Add(textBox_Datatyp);
            Controls.Add(button_Next);
            Controls.Add(button_Ignore);
            Controls.Add(button_Validate);
            Controls.Add(textBox_ColumnName);
            Controls.Add(label_ErrorMessage);
            Controls.Add(textBox_SourceFileName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogValidation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Validierungsfehler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SourceFileName;
        private System.Windows.Forms.Label label_ErrorMessage;
        private System.Windows.Forms.TextBox textBox_ColumnName;
        private System.Windows.Forms.Button button_Validate;
        private System.Windows.Forms.Button button_Ignore;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.TextBox textBox_Datatyp;
        private System.Windows.Forms.TextBox textBox_Value;
    }
}