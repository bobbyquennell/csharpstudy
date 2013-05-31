using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_Swap
{
    public partial class Form1 : Form
    {
        Elephant Lloyd, Lucinda;
        public Form1()
        {
            InitializeComponent();
            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 33};
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 40};
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant TempRef;
            TempRef = Lloyd;
            Lloyd = Lucinda;
            Lucinda = TempRef;
            MessageBox.Show("Objects swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd = Lucinda;
            Lloyd.EarSize = 4321;
            Lloyd.WhoAmI();
        }

    }
}
