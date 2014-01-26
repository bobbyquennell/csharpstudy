using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8Exercise1AClassHoldsAPlayingCard
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Suit mySuit;
        Value myValue;
        Card myCard;
        public Form1()
        {
            InitializeComponent();
   
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            mySuit = (Suit)random.Next(4);
            myValue = (Value)random.Next(1,14);
            myCard = new Card(mySuit, myValue);
            MessageBox.Show(myCard.Name);
        }
    }
}
