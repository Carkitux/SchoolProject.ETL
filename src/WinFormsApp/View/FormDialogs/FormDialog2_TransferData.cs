using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses.Transform;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

//https://stackoverflow.com/questions/19692514/get-value-from-dialog-window

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialog2_TransferData : Form
    {
        public FormDialog2_TransferData()
        {
            InitializeComponent();

            foreach (var item in StagingArea.StObjects)
            {
                comboBox_QuellStObj.Items.Add(item.Name);
            }
            foreach (var item in StagingArea.TransformStObject.Attributes)
            {
                comboBox_ZielAttribut.Items.Add(item.Name);
                comboBox_ZielAttribut2.Items.Add(item.Name);
            }

            radioButton_Transfer.Checked = true;

            ReCreateAndValidate();
        }

        string ZielAttribut;

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_QuellAttribute.SelectedItem is null && listBox_TransferFromTransform.SelectedItem is null)
            {
                MessageBox.Show("Bitte wählen Sie die Zielspalte aus und die Quellspalte.");
                return;
            }

            if (!(listBox_QuellAttribute.SelectedItem is null))
            {
                listBox_TransferToTransform.Items.Add(listBox_QuellAttribute.SelectedItem);
                listBox_QuellAttribute.Items.Remove(listBox_QuellAttribute.SelectedItem);
            }
            else if (!(listBox_TransferFromTransform.SelectedItem is null))
            {
                listBox_ZielAttribute.Items.Add(listBox_TransferFromTransform.SelectedItem);
                listBox_TransferFromTransform.Items.Remove(listBox_TransferFromTransform.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox_ZielAttribute.SelectedItem is null && listBox_TransferToTransform.SelectedItem is null)
            {
                MessageBox.Show("Bitte wählen Sie ein Quellattribut der Zielspalte aus das Sie entfernen möchten.");
                return;
            }

            if (!(listBox_ZielAttribute.SelectedItem is null))
            {
                listBox_TransferFromTransform.Items.Add(listBox_ZielAttribute.SelectedItem);
                listBox_ZielAttribute.Items.Remove(listBox_ZielAttribute.SelectedItem);
            }
            else if (!(listBox_TransferToTransform.SelectedItem is null))
            {
                listBox_QuellAttribute.Items.Add(listBox_TransferToTransform.SelectedItem);
                listBox_TransferToTransform.Items.Remove(listBox_TransferToTransform.SelectedItem);
            }
        }

        private void button_Ausfuehren_Click(object sender, EventArgs e)
        {


            ReCreateAndValidate();
        }

        private void button_Schließen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string[]> listbox3select = new List<string[]>();

            foreach (var item in listBox_TransferToTransform.Items)
            {
                listbox3select.Add(item.ToString().Split(" // "));
            }
            var listbox3group = listbox3select.GroupBy(x => x[0]).ToList();

            foreach (var group in listbox3group)
            {
                List<string> asd = new List<string>();
                foreach (var item in group)
                {
                    asd.Add(item[1]);
                }
                Transform.DataTransfer(group.Key, asd, ZielAttribut);
            }

            this.DialogResult = DialogResult.OK;
        }

        public void ReCreateAndValidate()
        {
            listBoxUpdate();

            if (radioButton_Transfer.Checked)
            {
                comboBox_ZielAttribut2.Enabled = false;
                textBox_Split.Enabled = false;
                textBox_Merge.Enabled = false;
            }
            else if (radioButton_Merge.Checked)
            {
                comboBox_ZielAttribut2.Enabled = false;
                textBox_Split.Enabled = false;
                textBox_Merge.Enabled = true;
            }
            else if (radioButton_Split.Checked)
            {
                comboBox_ZielAttribut2.Enabled = true;
                textBox_Split.Enabled = true;
                textBox_Merge.Enabled = false;
            }
        }

        private void listBoxUpdate()
        {
            listBox_TransferFromTransform.Items.Clear();
            listBox_QuellAttribute.Items.Clear();
            listBox_TransferToTransform.Items.Clear();
            listBox_ZielAttribute.Items.Clear();

            foreach (var stagingObject in StagingArea.StObjects.Where(x => x.Name == comboBox_QuellStObj.SelectedItem?.ToString()))
            {
                foreach (var attribut in stagingObject.Attributes.Where(x => x.WasTransferredTo.Count == 0).ToList())
                {
                    listBox_QuellAttribute.Items.Add(stagingObject.Name + " // " + attribut.Name);
                }
            }

            foreach (var attribut in StagingArea.TransformStObject.Attributes.Where(x => x.Name == comboBox_ZielAttribut.SelectedItem?.ToString()))
            {
                foreach (var sourceAttribut in attribut.WasTransferredFrom)
                {
                    listBox_ZielAttribute.Items.Add(sourceAttribut.StagingObject.Name + " // " + sourceAttribut.Name);
                }
            }
        }

        private void comboBox_QuellStObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void comboBox_ZielAttribut_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void radioButton_Transfer_CheckedChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void radioButton_Merge_CheckedChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void radioButton_Split_CheckedChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void listBox_TransferFromTransform_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_QuellAttribute.SelectedItem = null;
        }

        private void listBox_QuellAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_TransferFromTransform.SelectedItem = null;
        }

        private void listBox_TransferToTransform_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_ZielAttribute.SelectedItem = null;
        }

        private void listBox_ZielAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_TransferToTransform.SelectedItem = null;
        }
    }
}