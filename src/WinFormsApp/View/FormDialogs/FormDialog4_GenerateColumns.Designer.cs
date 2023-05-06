namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    partial class FormDialog4_GenerateColumns
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
            button_Okay = new System.Windows.Forms.Button();
            button_Cancel = new System.Windows.Forms.Button();
            comboBox_stagingObject = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button_Okay
            // 
            button_Okay.Location = new System.Drawing.Point(88, 129);
            button_Okay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button_Okay.Name = "button_Okay";
            button_Okay.Size = new System.Drawing.Size(81, 22);
            button_Okay.TabIndex = 0;
            button_Okay.Text = "Okay";
            button_Okay.UseVisualStyleBackColor = true;
            button_Okay.Click += button_Okay_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new System.Drawing.Point(173, 129);
            button_Cancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new System.Drawing.Size(81, 22);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Abbrechen";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // comboBox_stagingObject
            // 
            comboBox_stagingObject.FormattingEnabled = true;
            comboBox_stagingObject.Location = new System.Drawing.Point(5, 102);
            comboBox_stagingObject.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            comboBox_stagingObject.Name = "comboBox_stagingObject";
            comboBox_stagingObject.Size = new System.Drawing.Size(255, 23);
            comboBox_stagingObject.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 8);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(253, 90);
            label1.TabIndex = 3;
            label1.Text = "Wählen Sie die Quelldatenquelle aus,\r\nderen Spalten Sie übernehmen wollen.\r\n\r\nACHTUNG!\r\nEs werden alle bereits erstellte Spalten gelöscht\r\nund Datenzuweisungen zurückgesetzt!";
            // 
            // FormDialog4_GenerateColumns
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(265, 158);
            Controls.Add(comboBox_stagingObject);
            Controls.Add(button_Cancel);
            Controls.Add(button_Okay);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialog4_GenerateColumns";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button_Okay;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_stagingObject;
        private System.Windows.Forms.Label label1;
    }
}