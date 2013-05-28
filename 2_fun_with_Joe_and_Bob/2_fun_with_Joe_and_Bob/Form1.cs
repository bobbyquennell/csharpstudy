using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2_fun_with_Joe_and_Bob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            // Initialize joe and bob here
            //bob = new Guy();
            //joe = new Guy();
            //joe.Name = "Joe";
            //joe.Cash = 50;
            //bob.Name = "Bob";
            //bob.Cash = 100;
            bob = new Guy() { Name = "Bob", Cash = 100};
            joe = new Guy() { Name = "Joe", Cash = 50 };
            UpdateForm();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void UpdateForm() 
        {
            JoesCashlabel.Text = joe.Name + " has $" + joe.Cash;
            BobsCashlabel.Text = bob.Name + " has $" + bob.Cash;
            BanksCashlabel.Text = "Then bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();

        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                bob.Cash += joe.GiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe is out of money.");
            }

        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                joe.Cash += bob.GiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob is out of money.");
            }
        }

    }
}
