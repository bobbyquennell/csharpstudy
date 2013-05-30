using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = 0.39, amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void CaculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)StartMileagenumericUpDown.Value;
            endingMileage = (int)EndMileagenumericUpDown.Value;

            if (startingMileage >= endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Caculate");

            }
            milesTraveled = endingMileage - startingMileage;
            amountOwed = milesTraveled * reimburseRate;
            label4.Text = "$" + amountOwed;

        }

        private void MileDisplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled.ToString() + " miles", "Miles Traveled");
        }
    }
}
