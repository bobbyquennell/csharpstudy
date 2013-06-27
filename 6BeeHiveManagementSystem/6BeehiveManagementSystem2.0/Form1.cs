using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6BeehiveManagementSystem2_0
{
    public partial class Form1 : Form
    {
        Queen myQueen;
        public Form1()
        {
            InitializeComponent();
            worker[] myworkers = new worker[4];
            /*
            job list:
            Nectar collector
            Egg care
            Hive maintenance
            Baby bee tutoring
            Honey manufacturing
            Sting patrol*/

            myworkers[0] = new worker(175, new string[] { "Nectar collector", "Honey manufacturing"});
            myworkers[1] = new worker(114, new string[] { "Egg care", "Baby bee tutoring"});
            myworkers[2] = new worker(149, new string[] { "Hive maintenance", "Sting patrol" });
            myworkers[3] = new worker(155, new string[] {"Nectar collector", "Honey manufacturing", "Egg care",
                           "Baby bee tutoring", "Hive maintenance", "Sting patrol"});

            myQueen = new Queen(myworkers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!myQueen.AssignWork(workerbeeJobcomboBox.Text, (int)numericUpDown1.Value))
                MessageBox.Show("Cannot find a bee to do this job" + workerbeeJobcomboBox.Text, "The queen bee says...");
            else
                MessageBox.Show("The job '" + workerbeeJobcomboBox.Text + "' will be done in "
                      + numericUpDown1.Value + " shifts", "The queen bee says...");
        }

        private void workShiftsButton_Click(object sender, EventArgs e)
        {
            ReportTextBox.Text = myQueen.WorkTheNextShift();

        }
    }
}
