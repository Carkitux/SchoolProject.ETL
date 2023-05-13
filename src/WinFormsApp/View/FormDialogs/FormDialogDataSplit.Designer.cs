namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    partial class FormDialogDataSplit
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
            components = new System.ComponentModel.Container();
            listBox_QuellAttribute = new System.Windows.Forms.ListBox();
            listBox_TransferToTransform = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button_Schließen = new System.Windows.Forms.Button();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            comboBox_QuellStObj = new System.Windows.Forms.ComboBox();
            button_Ausfuehren = new System.Windows.Forms.Button();
            textBox_Split = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // listBox_QuellAttribute
            // 
            listBox_QuellAttribute.FormattingEnabled = true;
            listBox_QuellAttribute.ItemHeight = 15;
            listBox_QuellAttribute.Location = new System.Drawing.Point(8, 86);
            listBox_QuellAttribute.Name = "listBox_QuellAttribute";
            listBox_QuellAttribute.Size = new System.Drawing.Size(262, 199);
            listBox_QuellAttribute.TabIndex = 1;
            listBox_QuellAttribute.SelectedIndexChanged += listBox_QuellAttribute_SelectedIndexChanged;
            // 
            // listBox_TransferToTransform
            // 
            listBox_TransferToTransform.FormattingEnabled = true;
            listBox_TransferToTransform.ItemHeight = 15;
            listBox_TransferToTransform.Location = new System.Drawing.Point(401, 86);
            listBox_TransferToTransform.Name = "listBox_TransferToTransform";
            listBox_TransferToTransform.Size = new System.Drawing.Size(241, 199);
            listBox_TransferToTransform.TabIndex = 2;
            listBox_TransferToTransform.SelectedIndexChanged += listBox_TransferToTransform_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(298, 87);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(69, 23);
            button1.TabIndex = 3;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(298, 111);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(69, 23);
            button2.TabIndex = 4;
            button2.Text = "<-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_Schließen
            // 
            button_Schließen.Location = new System.Drawing.Point(565, 293);
            button_Schließen.Name = "button_Schließen";
            button_Schließen.Size = new System.Drawing.Size(75, 23);
            button_Schließen.TabIndex = 5;
            button_Schließen.Text = "Schließen";
            button_Schließen.UseVisualStyleBackColor = true;
            button_Schließen.Click += button_Schließen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "Quelle";
            // 
            // comboBox_QuellStObj
            // 
            comboBox_QuellStObj.FormattingEnabled = true;
            comboBox_QuellStObj.Location = new System.Drawing.Point(8, 21);
            comboBox_QuellStObj.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            comboBox_QuellStObj.Name = "comboBox_QuellStObj";
            comboBox_QuellStObj.Size = new System.Drawing.Size(262, 23);
            comboBox_QuellStObj.TabIndex = 10;
            comboBox_QuellStObj.Text = "Bitte auswählen";
            comboBox_QuellStObj.SelectedIndexChanged += comboBox_QuellStObj_SelectedIndexChanged;
            // 
            // button_Ausfuehren
            // 
            button_Ausfuehren.Location = new System.Drawing.Point(437, 294);
            button_Ausfuehren.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button_Ausfuehren.Name = "button_Ausfuehren";
            button_Ausfuehren.Size = new System.Drawing.Size(123, 22);
            button_Ausfuehren.TabIndex = 12;
            button_Ausfuehren.Text = "Ausführen";
            button_Ausfuehren.UseVisualStyleBackColor = true;
            button_Ausfuehren.Click += button_Ausfuehren_Click;
            // 
            // textBox_Split
            // 
            textBox_Split.Location = new System.Drawing.Point(297, 158);
            textBox_Split.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            textBox_Split.Name = "textBox_Split";
            textBox_Split.PlaceholderText = "Seperator";
            textBox_Split.Size = new System.Drawing.Size(71, 23);
            textBox_Split.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(401, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 15);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // FormDialogDataSplit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(648, 322);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox_Split);
            Controls.Add(listBox_TransferToTransform);
            Controls.Add(button_Ausfuehren);
            Controls.Add(comboBox_QuellStObj);
            Controls.Add(label2);
            Controls.Add(button_Schließen);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox_QuellAttribute);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogDataSplit";
            ShowInTaskbar = false;
            Text = "Datentransfer";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox listBox_QuellAttribute;
        private System.Windows.Forms.ListBox listBox_TransferToTransform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Schließen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_QuellStObj;
        private System.Windows.Forms.Button button_Ausfuehren;
        private System.Windows.Forms.TextBox textBox_Split;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}