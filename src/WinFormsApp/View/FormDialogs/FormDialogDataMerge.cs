using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.LogicClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

//https://stackoverflow.com/questions/19692514/get-value-from-dialog-window

namespace SchoolProject.ETL.UI.WinFormsApp.View.FormDialogs
{
    public partial class FormDialogDataMerge : Form
    {
        public FormDialogDataMerge()
        {
            InitializeComponent();

            foreach (var item in StagingArea.StObjects)
            {
                comboBox_QuellStObj.Items.Add(item.Name);
            }

            ReCreateAndValidate();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(listBox_QuellAttribute.SelectedItem is null))
            {
                listBox_TransferToMergeSplit.Items.Add(listBox_QuellAttribute.SelectedItem);
                listBox_QuellAttribute.Items.Remove(listBox_QuellAttribute.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(listBox_TransferToMergeSplit.SelectedItem is null))
            {
                listBox_QuellAttribute.Items.Add(listBox_TransferToMergeSplit.SelectedItem);
                listBox_TransferToMergeSplit.Items.Remove(listBox_TransferToMergeSplit.SelectedItem);
            }
        }

        private void button_Ausfuehren_Click(object sender, EventArgs e)
        {
            var stageObject = StagingArea.StObjects
                .Where(x => x.Name == (string)comboBox_QuellStObj.SelectedItem)
                .FirstOrDefault();
            var attributes = new List<string>();
            foreach (var item in listBox_TransferToMergeSplit.Items) { attributes.Add(item.ToString().Split(" // ")[1]); }

            Transform.DataMerge(stageObject.Name, attributes, textBox_Merge.Text);

            ReCreateAndValidate();
        }

        private void button_Schließen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string[]> listbox3select = new List<string[]>();

            foreach (var item in listBox_TransferToMergeSplit.Items)
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
                //Transform.DataTransfer(group.Key, asd, "");
            }

            this.DialogResult = DialogResult.OK;
        }

        public void ReCreateAndValidate()
        {
            listBoxUpdate();
        }

        private void listBoxUpdate()
        {
            listBox_QuellAttribute.Items.Clear();
            listBox_TransferToMergeSplit.Items.Clear();
            listBox_MergeSplitAttribute.Items.Clear();

            foreach (var stagingObject in StagingArea.StObjects.Where(x => x.Name == comboBox_QuellStObj.SelectedItem?.ToString()))
            {
                foreach (var attribut in stagingObject.Attributes.Where(x => x.TransferredTo.Count == 0).ToList())
                {
                    listBox_QuellAttribute.Items.Add(stagingObject.Name + " // " + attribut.Name);
                }
            }

            foreach (var attribut in StagingArea.SplitMergeStObject.Attributes)
            {
                listBox_MergeSplitAttribute.Items.Add(attribut);
            }
        }

        private void comboBox_QuellStObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReCreateAndValidate();
        }

        private void listBox_TransferToTransform_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_MergeSplitAttribute.SelectedItem = null;
        }

        private void listBox_ZielAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentListBox = (ListBox)sender;
            if (currentListBox.SelectedItem is null)
            {
                return;
            }
            listBox_TransferToMergeSplit.SelectedItem = null;
        }
    }
}