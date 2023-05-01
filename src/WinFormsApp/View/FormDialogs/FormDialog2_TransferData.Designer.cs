namespace ETL_SFC_WindowsForms
{
    partial class FormDialog2_TransferData
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
            label3 = new System.Windows.Forms.Label();
            comboBox_QuellStObj = new System.Windows.Forms.ComboBox();
            button_Reset = new System.Windows.Forms.Button();
            button_Ausfuehren = new System.Windows.Forms.Button();
            comboBox_ZielAttribut = new System.Windows.Forms.ComboBox();
            comboBox_ZielAttribut2 = new System.Windows.Forms.ComboBox();
            radioButton_Transfer = new System.Windows.Forms.RadioButton();
            radioButton_Merge = new System.Windows.Forms.RadioButton();
            radioButton_Split = new System.Windows.Forms.RadioButton();
            listBox_ZielAttribute = new System.Windows.Forms.ListBox();
            textBox_Split = new System.Windows.Forms.TextBox();
            textBox_Merge = new System.Windows.Forms.TextBox();
            listBox_TransferFromTransform = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // listBox_QuellAttribute
            // 
            listBox_QuellAttribute.FormattingEnabled = true;
            listBox_QuellAttribute.ItemHeight = 15;
            listBox_QuellAttribute.Location = new System.Drawing.Point(8, 120);
            listBox_QuellAttribute.Name = "listBox_QuellAttribute";
            listBox_QuellAttribute.Size = new System.Drawing.Size(262, 169);
            listBox_QuellAttribute.TabIndex = 1;
            // 
            // listBox_TransferToTransform
            // 
            listBox_TransferToTransform.FormattingEnabled = true;
            listBox_TransferToTransform.ItemHeight = 15;
            listBox_TransferToTransform.Location = new System.Drawing.Point(401, 70);
            listBox_TransferToTransform.Name = "listBox_TransferToTransform";
            listBox_TransferToTransform.Size = new System.Drawing.Size(241, 49);
            listBox_TransferToTransform.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(298, 68);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(69, 23);
            button1.TabIndex = 3;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(298, 92);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(401, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Transferierte Spalten";
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
            // button_Reset
            // 
            button_Reset.Location = new System.Drawing.Point(298, 19);
            button_Reset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new System.Drawing.Size(69, 22);
            button_Reset.TabIndex = 11;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // button_Ausfuehren
            // 
            button_Ausfuehren.Location = new System.Drawing.Point(274, 240);
            button_Ausfuehren.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button_Ausfuehren.Name = "button_Ausfuehren";
            button_Ausfuehren.Size = new System.Drawing.Size(123, 22);
            button_Ausfuehren.TabIndex = 12;
            button_Ausfuehren.Text = "Ausführen";
            button_Ausfuehren.UseVisualStyleBackColor = true;
            button_Ausfuehren.Click += button_Ausfuehren_Click;
            // 
            // comboBox_ZielAttribut
            // 
            comboBox_ZielAttribut.FormattingEnabled = true;
            comboBox_ZielAttribut.Location = new System.Drawing.Point(401, 22);
            comboBox_ZielAttribut.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            comboBox_ZielAttribut.Name = "comboBox_ZielAttribut";
            comboBox_ZielAttribut.Size = new System.Drawing.Size(241, 23);
            comboBox_ZielAttribut.TabIndex = 13;
            comboBox_ZielAttribut.Text = "1. Zielspalte";
            comboBox_ZielAttribut.SelectedIndexChanged += comboBox_ZielAttribut_SelectedIndexChanged;
            // 
            // comboBox_ZielAttribut2
            // 
            comboBox_ZielAttribut2.FormattingEnabled = true;
            comboBox_ZielAttribut2.Location = new System.Drawing.Point(401, 46);
            comboBox_ZielAttribut2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            comboBox_ZielAttribut2.Name = "comboBox_ZielAttribut2";
            comboBox_ZielAttribut2.Size = new System.Drawing.Size(241, 23);
            comboBox_ZielAttribut2.TabIndex = 14;
            comboBox_ZielAttribut2.Text = "2. Zielspalte für Datensplitting";
            // 
            // radioButton_Transfer
            // 
            radioButton_Transfer.AutoSize = true;
            radioButton_Transfer.Location = new System.Drawing.Point(298, 131);
            radioButton_Transfer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            radioButton_Transfer.Name = "radioButton_Transfer";
            radioButton_Transfer.Size = new System.Drawing.Size(66, 19);
            radioButton_Transfer.TabIndex = 15;
            radioButton_Transfer.TabStop = true;
            radioButton_Transfer.Text = "Transfer";
            radioButton_Transfer.UseVisualStyleBackColor = true;
            radioButton_Transfer.CheckedChanged += radioButton_Transfer_CheckedChanged;
            // 
            // radioButton_Merge
            // 
            radioButton_Merge.AutoSize = true;
            radioButton_Merge.Location = new System.Drawing.Point(298, 151);
            radioButton_Merge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            radioButton_Merge.Name = "radioButton_Merge";
            radioButton_Merge.Size = new System.Drawing.Size(59, 19);
            radioButton_Merge.TabIndex = 16;
            radioButton_Merge.TabStop = true;
            radioButton_Merge.Text = "Merge";
            radioButton_Merge.UseVisualStyleBackColor = true;
            radioButton_Merge.CheckedChanged += radioButton_Merge_CheckedChanged;
            // 
            // radioButton_Split
            // 
            radioButton_Split.AutoSize = true;
            radioButton_Split.Location = new System.Drawing.Point(298, 194);
            radioButton_Split.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            radioButton_Split.Name = "radioButton_Split";
            radioButton_Split.Size = new System.Drawing.Size(48, 19);
            radioButton_Split.TabIndex = 17;
            radioButton_Split.TabStop = true;
            radioButton_Split.Text = "Split";
            radioButton_Split.UseVisualStyleBackColor = true;
            radioButton_Split.CheckedChanged += radioButton_Split_CheckedChanged;
            // 
            // listBox_ZielAttribute
            // 
            listBox_ZielAttribute.FormattingEnabled = true;
            listBox_ZielAttribute.ItemHeight = 15;
            listBox_ZielAttribute.Location = new System.Drawing.Point(401, 120);
            listBox_ZielAttribute.Name = "listBox_ZielAttribute";
            listBox_ZielAttribute.Size = new System.Drawing.Size(241, 169);
            listBox_ZielAttribute.TabIndex = 18;
            // 
            // textBox_Split
            // 
            textBox_Split.Location = new System.Drawing.Point(298, 213);
            textBox_Split.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            textBox_Split.Name = "textBox_Split";
            textBox_Split.PlaceholderText = "Seperator";
            textBox_Split.Size = new System.Drawing.Size(71, 23);
            textBox_Split.TabIndex = 19;
            // 
            // textBox_Merge
            // 
            textBox_Merge.Location = new System.Drawing.Point(298, 171);
            textBox_Merge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            textBox_Merge.Name = "textBox_Merge";
            textBox_Merge.PlaceholderText = "Connector";
            textBox_Merge.Size = new System.Drawing.Size(71, 23);
            textBox_Merge.TabIndex = 20;
            // 
            // listBox_TransferFromTransform
            // 
            listBox_TransferFromTransform.FormattingEnabled = true;
            listBox_TransferFromTransform.ItemHeight = 15;
            listBox_TransferFromTransform.Location = new System.Drawing.Point(8, 70);
            listBox_TransferFromTransform.Name = "listBox_TransferFromTransform";
            listBox_TransferFromTransform.Size = new System.Drawing.Size(262, 49);
            listBox_TransferFromTransform.TabIndex = 21;
            // 
            // FormDialog2_TransferData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(648, 322);
            Controls.Add(listBox_TransferFromTransform);
            Controls.Add(textBox_Merge);
            Controls.Add(textBox_Split);
            Controls.Add(listBox_ZielAttribute);
            Controls.Add(radioButton_Split);
            Controls.Add(radioButton_Merge);
            Controls.Add(radioButton_Transfer);
            Controls.Add(comboBox_ZielAttribut2);
            Controls.Add(listBox_TransferToTransform);
            Controls.Add(comboBox_ZielAttribut);
            Controls.Add(button_Ausfuehren);
            Controls.Add(button_Reset);
            Controls.Add(comboBox_QuellStObj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_Schließen);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox_QuellAttribute);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialog2_TransferData";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_QuellStObj;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Ausfuehren;
        private System.Windows.Forms.ComboBox comboBox_ZielAttribut;
        private System.Windows.Forms.ComboBox comboBox_ZielAttribut2;
        private System.Windows.Forms.RadioButton radioButton_Transfer;
        private System.Windows.Forms.RadioButton radioButton_Merge;
        private System.Windows.Forms.RadioButton radioButton_Split;
        private System.Windows.Forms.ListBox listBox_ZielAttribute;
        private System.Windows.Forms.TextBox textBox_Split;
        private System.Windows.Forms.TextBox textBox_Merge;
        private System.Windows.Forms.ListBox listBox_TransferFromTransform;
    }
}