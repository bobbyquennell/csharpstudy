using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _9UsingFileDialogsToOpenandSaveFiles
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "C:\\Users\\LogicPlatypus\\Downloads";
            saveFileDialog1.Title = "change title text";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                TextEditorBox.Clear();
                name = openFileDialog1.FileName;
                TextEditorBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, TextEditorBox.Text);
        }
    }
}
