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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if ((result == DialogResult.OK) && (folderBrowserDialog1.SelectedPath != ""))
            {
                buttonOpen.Enabled = true;
                buttonSave.Enabled = true;
                buttonRandom.Enabled = true;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName, textBoxExcuse.Text+ textBoxResults.Text);
                labelFileDate.Text = File.GetLastAccessTime(saveFileDialog1.FileName).ToString();
                this.Text = "Excuse Manager";

            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.OpenRead(openFileDialog1.FileName);
                labelFileDate.Text = File.GetLastAccessTime(saveFileDialog1.FileName).ToString();

            }

        }

        private void textBoxExcuse_TextChanged(object sender, EventArgs e)
        {
            this.Text +=  "*";
        }

        private void textBoxResults_TextChanged(object sender, EventArgs e)
        {
            this.Text += "*";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text += "*";
        }
    } 
}
