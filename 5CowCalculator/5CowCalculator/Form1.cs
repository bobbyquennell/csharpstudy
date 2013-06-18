using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5CowCalculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(){ NumberOfCows = 15/*, feedMultiplier = 30 */};
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows",
                farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //farmer.BagsOfFeed = 5; // private set method for: public int BagsOfFeed { get; private set; }
            //if set method is private, then it cannot be used outside the object.
        }
    }
}
