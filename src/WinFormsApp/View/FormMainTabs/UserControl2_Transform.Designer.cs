namespace ETL_SFC_WindowsForms
{
    partial class UserControl2_Transform
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
            button_DataValidateMenu = new System.Windows.Forms.Button();
            button_DataTransferMenu = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            button_ColumnMenu = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_DataValidateMenu
            // 
            button_DataValidateMenu.BackColor = System.Drawing.Color.LightGray;
            button_DataValidateMenu.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataValidateMenu.FlatAppearance.BorderSize = 0;
            button_DataValidateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataValidateMenu.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataValidateMenu.Location = new System.Drawing.Point(254, 0);
            button_DataValidateMenu.Name = "button_DataValidateMenu";
            button_DataValidateMenu.Size = new System.Drawing.Size(127, 49);
            button_DataValidateMenu.TabIndex = 2;
            button_DataValidateMenu.Text = "Validieren\r\nMenü";
            button_DataValidateMenu.UseVisualStyleBackColor = false;
            button_DataValidateMenu.Click += button_DataValidateMenu_Click;
            // 
            // button_DataTransferMenu
            // 
            button_DataTransferMenu.AutoEllipsis = true;
            button_DataTransferMenu.BackColor = System.Drawing.Color.LightGray;
            button_DataTransferMenu.Dock = System.Windows.Forms.DockStyle.Left;
            button_DataTransferMenu.FlatAppearance.BorderSize = 0;
            button_DataTransferMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DataTransferMenu.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DataTransferMenu.Location = new System.Drawing.Point(127, 0);
            button_DataTransferMenu.Name = "button_DataTransferMenu";
            button_DataTransferMenu.Size = new System.Drawing.Size(127, 49);
            button_DataTransferMenu.TabIndex = 1;
            button_DataTransferMenu.Text = "Datentransfer\r\nMenü";
            button_DataTransferMenu.UseVisualStyleBackColor = false;
            button_DataTransferMenu.Click += button_DataTransferMenu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(590, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderCellChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(button_DataValidateMenu);
            panel1.Controls.Add(button_DataTransferMenu);
            panel1.Controls.Add(button_ColumnMenu);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 49);
            panel1.TabIndex = 1;
            // 
            // button_ColumnMenu
            // 
            button_ColumnMenu.BackColor = System.Drawing.Color.LightGray;
            button_ColumnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            button_ColumnMenu.FlatAppearance.BorderSize = 0;
            button_ColumnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ColumnMenu.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_ColumnMenu.Location = new System.Drawing.Point(0, 0);
            button_ColumnMenu.Name = "button_ColumnMenu";
            button_ColumnMenu.Size = new System.Drawing.Size(127, 49);
            button_ColumnMenu.TabIndex = 3;
            button_ColumnMenu.Text = "Spalten\r\nMenü";
            button_ColumnMenu.UseVisualStyleBackColor = false;
            button_ColumnMenu.Click += button_ColumnMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(statusStrip1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(210, 98);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(590, 502);
            panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 480);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(590, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(800, 49);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 98);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(210, 502);
            panel4.TabIndex = 4;
            // 
            // UserControl2_Transform
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UserControl2_Transform";
            Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_DataTransferMenu;
        private System.Windows.Forms.Button button_DataValidateMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_ColumnMenu;
    }
}
