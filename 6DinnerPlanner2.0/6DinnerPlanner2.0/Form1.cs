using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6DinnerPlanner2._0
{
    public partial class Form1 : Form
    {
        DinnerParty myDinnerParty;
        BirthdayParty myBirthdayParty;
        public Form1()
        {
            InitializeComponent();
            myBirthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            myDinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox2.Checked, checkBox1.Checked);
            DisplayDinnerCost(myDinnerParty);
            DisplayBirthdayCost(myBirthdayParty);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myDinnerParty.NumOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerCost(myDinnerParty);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            myDinnerParty.HealthyOption = checkBox1.Checked;
            DisplayDinnerCost(myDinnerParty);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            myDinnerParty.FancyDecoration = checkBox2.Checked;
            DisplayDinnerCost(myDinnerParty);
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            myBirthdayParty.NumOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayCost(myBirthdayParty);
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            myBirthdayParty.IsFancyDecoration = fancyBirthday.Checked;
            DisplayBirthdayCost(myBirthdayParty);
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            myBirthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayCost(myBirthdayParty);
        }
        private void DisplayDinnerCost(DinnerParty dinnerParty)
        {
            dinnerPartyCost.Text = dinnerParty.GetPartyCost().ToString("c");
        }
        private void DisplayBirthdayCost(BirthdayParty birthdayParty)
        {
            birthdayCost.Text = birthdayParty.CalculateCost().ToString("c");
        }
    }
}
