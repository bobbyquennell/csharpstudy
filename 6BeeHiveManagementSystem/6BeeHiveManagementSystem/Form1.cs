using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6BeeHiveManagementSystem
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

            myworkers[0] = new worker(new string[] { "Nectar collector", "Honey manufacturing"});
            myworkers[1] = new worker(new string[] { "Egg care", "Baby bee tutoring"});
            myworkers[2] = new worker(new string[] { "Hive maintenance", "Sting patrol" });
            myworkers[3] = new worker(new string[] {"Nectar collector", "Honey manufacturing", "Egg care",
                           "Baby bee tutoring", "Hive maintenance", "Sting patrol"});

            myQueen = new Queen(myworkers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!myQueen.AssignWork(workerbeeJobcomboBox.SelectedItem.ToString(), (int)numericUpDown1.Value))
                MessageBox.Show("Cannot find a bee to do this job");
        }

        private void workShiftsButton_Click(object sender, EventArgs e)
        {
            ReportTextBox.Text = myQueen.WorkTheNextShift();

        }
    }
}
