namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    partial class FormDialogDataMerge
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
            listBox_TransferToMergeSplit = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button_Schließen = new System.Windows.Forms.Button();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            comboBox_QuellStObj = new System.Windows.Forms.ComboBox();
            button_Ausfuehren = new System.Windows.Forms.Button();
            listBox_MergeSplitAttribute = new System.Windows.Forms.ListBox();
            textBox_Merge = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
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
            // 
            // listBox_TransferToMergeSplit
            // 
            listBox_TransferToMergeSplit.FormattingEnabled = true;
            listBox_TransferToMergeSplit.ItemHeight = 15;
            listBox_TransferToMergeSplit.Location = new System.Drawing.Point(401, 86);
            listBox_TransferToMergeSplit.Name = "listBox_TransferToMergeSplit";
            listBox_TransferToMergeSplit.Size = new System.Drawing.Size(241, 49);
            listBox_TransferToMergeSplit.TabIndex = 2;
            listBox_TransferToMergeSplit.SelectedIndexChanged += listBox_TransferToTransform_SelectedIndexChanged;
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
            // listBox_MergeSplitAttribute
            // 
            listBox_MergeSplitAttribute.FormattingEnabled = true;
            listBox_MergeSplitAttribute.ItemHeight = 15;
            listBox_MergeSplitAttribute.Location = new System.Drawing.Point(401, 161);
            listBox_MergeSplitAttribute.Name = "listBox_MergeSplitAttribute";
            listBox_MergeSplitAttribute.Size = new System.Drawing.Size(241, 124);
            listBox_MergeSplitAttribute.TabIndex = 18;
            listBox_MergeSplitAttribute.SelectedIndexChanged += listBox_ZielAttribute_SelectedIndexChanged;
            // 
            // textBox_Merge
            // 
            textBox_Merge.Location = new System.Drawing.Point(296, 165);
            textBox_Merge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            textBox_Merge.Name = "textBox_Merge";
            textBox_Merge.PlaceholderText = "Connector";
            textBox_Merge.Size = new System.Drawing.Size(71, 23);
            textBox_Merge.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 22;
            label1.Text = "Quellspalten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(401, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 15);
            label5.TabIndex = 24;
            label5.Text = "Zu mergende Spalten";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(401, 143);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(198, 15);
            label6.TabIndex = 25;
            label6.Text = "Bereits gemergte/gesplittete Spalten";
            // 
            // FormDialogDataMerge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(648, 322);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox_Merge);
            Controls.Add(listBox_MergeSplitAttribute);
            Controls.Add(listBox_TransferToMergeSplit);
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
            Name = "FormDialogDataMerge";
            ShowInTaskbar = false;
            Text = "Datenmerge";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox listBox_QuellAttribute;
        private System.Windows.Forms.ListBox listBox_TransferToMergeSplit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Schließen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_QuellStObj;
        private System.Windows.Forms.Button button_Ausfuehren;
        private System.Windows.Forms.ListBox listBox_MergeSplitAttribute;
        private System.Windows.Forms.TextBox textBox_Merge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}