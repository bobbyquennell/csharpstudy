using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6PartyPlanner2._1
{
    public partial class Form1 : Form
    {
        DinnerParty mydinnerParty;
        BirthdayParty mybirthdayParty;
        public Form1()
        {
            InitializeComponent();
            mydinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox2.Checked, checkBox1.Checked);
            mybirthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayDinnerCost(mydinnerParty);
            DisplayBirthdayCost(mybirthdayParty);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mydinnerParty.NumOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerCost(mydinnerParty);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mydinnerParty.IsFancyDecoration = checkBox2.Checked;
            DisplayDinnerCost(mydinnerParty);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mydinnerParty.HealthyOption = checkBox1.Checked;
            DisplayDinnerCost(mydinnerParty);
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            mybirthdayParty.NumOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayCost(mybirthdayParty);
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            mybirthdayParty.IsFancyDecoration = fancyBirthday.Checked;
            DisplayBirthdayCost(mybirthdayParty);
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            mybirthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayCost(mybirthdayParty);
        }
        private void DisplayDinnerCost(DinnerParty dinnerParty)
        {
            dinnerPartyCost.Text = dinnerParty.CalculatePartyCost().ToString("c");
        }
        private void DisplayBirthdayCost(BirthdayParty birthdayParty)
        {
            birthdayCost.Text = birthdayParty.CalculatePartyCost().ToString("c");
        }
    }
}
