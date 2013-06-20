using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5NewDinnerPartywithProperty
{
    public partial class Form1 : Form
    {
        DinnerParty myParty;
        public Form1()
        {
            InitializeComponent();
            myParty = new DinnerParty((int)numericUpDown1.Value,checkBox2.Checked,checkBox1.Checked);
            DisplayCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myParty.NumOfPeople = (int)numericUpDown1.Value;
            DisplayCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                myParty.HealthyOption = true;
            }
            else
            {
                myParty.HealthyOption = false;
            }
            DisplayCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                myParty.FancyDecoration = true;
                
            }
            else
            {
                myParty.FancyDecoration = false;
            }
            DisplayCost();
        }
        private void DisplayCost()
        {
            label3.Text = "$" + myParty.GetPartyCost().ToString();
        }
    }
}
