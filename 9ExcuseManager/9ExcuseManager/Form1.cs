using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _9ExcuseManager
{
    public partial class Form1 : Form
    {
        private Excuse CurrentExcuse = new Excuse();
        private bool formChanged = false;
        private string workingpath = "";
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            CurrentExcuse.lastused = dateTimePickerLastUsed.Value;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.SelectedPath = workingpath;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if ((result == DialogResult.OK) && (folderBrowserDialog1.SelectedPath != ""))
            {
                buttonOpen.Enabled = true;
                buttonSave.Enabled = true;
                buttonRandom.Enabled = true;
                workingpath = folderBrowserDialog1.SelectedPath;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = workingpath;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*|";
            saveFileDialog1.FileName = textBoxExcuse.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if((String.IsNullOrEmpty(textBoxExcuse.Text)) ||(String.IsNullOrEmpty(textBoxResults.Text)))
                    MessageBox.Show("Please specify an excuse and a result","Unable to Save",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                else{
                    CurrentExcuse.description = textBoxExcuse.Text;
                    CurrentExcuse.results = textBoxResults.Text;
                    CurrentExcuse.lastused = dateTimePickerLastUsed.Value;
                    CurrentExcuse.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Excuse Written");
                    //File.SetLastWriteTime(workingpath + saveFileDialog1.FileName, System.DateTime.Now);
                    //labelFileDate.Text = "";//????
                    UpdateForm(false);
                }
                //File.AppendAllText(saveFileDialog1.FileName, textBoxExcuse.Text+ textBoxResults.Text);
                //labelTitleofFileDate.Text = File.GetLastAccessTime(saveFileDialog1.FileName).ToString();
                //this.Text = "Excuse Manager";

            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = workingpath;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*|";
            //openFileDialog1.FileName = textBoxExcuse.Text + ".txt";
            DialogResult result = openFileDialog1.ShowDialog();
            DialogResult MessageResult = System.Windows.Forms.DialogResult.No;
            if (result == DialogResult.OK)
            {
                if(this.formChanged == true){

                    MessageResult= MessageBox.Show("The current excuse has not been saved, Continue?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                }
                if((MessageResult == DialogResult.Yes)||(this.formChanged == false)){
                    CurrentExcuse = new Excuse(workingpath);
                    CurrentExcuse.Open(openFileDialog1.FileName);
                    //textBoxExcuse.Text = CurrentExcuse.description;
                    //textBoxResults.Text = CurrentExcuse.results;
                    //dateTimePickerLastUsed.Value = CurrentExcuse.lastused;
                    UpdateForm(false);
                        //
                        //File.OpenRead(openFileDialog1.FileName);
                    //labelTitleofFileDate.Text = File.GetLastAccessTime(saveFileDialog1.FileName).ToString();
                }

            }

        }

        private void textBoxExcuse_TextChanged(object sender, EventArgs e)
        {
            CurrentExcuse.description = textBoxExcuse.Text;
            UpdateForm(true);
        }

        private void textBoxResults_TextChanged(object sender, EventArgs e)
        {
            CurrentExcuse.results = textBoxResults.Text;
            UpdateForm(true);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CurrentExcuse.lastused = dateTimePickerLastUsed.Value;
            UpdateForm(true);
        }
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.textBoxExcuse.Text = CurrentExcuse.description;
                this.textBoxResults.Text = CurrentExcuse.results;
                this.dateTimePickerLastUsed.Value = CurrentExcuse.lastused;
                if (!String.IsNullOrEmpty(CurrentExcuse.excusepath))
                    this.labelFileDate.Text = File.GetLastWriteTime(CurrentExcuse.excusepath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            DialogResult MessageResult = System.Windows.Forms.DialogResult.No;
                
            if(this.formChanged == true){

                MessageResult= MessageBox.Show("The current excuse has not been saved, Continue?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            if((MessageResult == DialogResult.Yes)||(this.formChanged == false)){
                CurrentExcuse = new Excuse(random, workingpath);
                UpdateForm(false);
            }
        }
          
    } 
}
