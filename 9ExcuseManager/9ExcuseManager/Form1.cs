using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
