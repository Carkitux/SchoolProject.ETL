namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    partial class FormDialogDefaultConfirmation
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
            label1 = new System.Windows.Forms.Label();
            button_Okay = new System.Windows.Forms.Button();
            button_Cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(146, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Okay
            // 
            button_Okay.Location = new System.Drawing.Point(163, 54);
            button_Okay.Name = "button_Okay";
            button_Okay.Size = new System.Drawing.Size(75, 23);
            button_Okay.TabIndex = 1;
            button_Okay.Text = "Okay";
            button_Okay.UseVisualStyleBackColor = true;
            button_Okay.Click += button_Okay_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new System.Drawing.Point(244, 54);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new System.Drawing.Size(75, 23);
            button_Cancel.TabIndex = 2;
            button_Cancel.Text = "Abbrechen";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // FormDialog3_Confirmation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(331, 89);
            Controls.Add(button_Cancel);
            Controls.Add(button_Okay);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialog3_Confirmation";
            ShowInTaskbar = false;
            Text = "FormDialog3_Confirmation";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Okay;
        private System.Windows.Forms.Button button_Cancel;
    }
}