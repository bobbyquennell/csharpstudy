using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8BreakfastForLumberjacks
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> LumberjackQueue = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddLumberjack_Click(object sender, EventArgs e)
        {
            LumberjackQueue.Enqueue(new Lumberjack(textBoxLumberName.Text));
            textBoxLumberName.Text = "";
            RedrawList();
        }

        private void buttonAddFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (radioButtonCrispy.Checked == true)
                food = Flapjack.Crispy;
            else if (radioButtonSoggy.Checked == true)
                food = Flapjack.Soggy;
            else if(radioButtonBrowned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = LumberjackQueue.Peek();
            currentLumberjack.TakeFlapjacks(food,(int)numericUpDownHowMany.Value);
            RedrawList();
        }

        private void buttonNextLumber_Click(object sender, EventArgs e)
        {
            if (LumberjackQueue.Count > 0)
            {
                Lumberjack nextLumberjack = LumberjackQueue.Dequeue();
                nextLumberjack.EatFlapjacks();
                RedrawList();
            }
        }
        private void RedrawList()
        {
            List<Lumberjack> AllLumberjackList = new List<Lumberjack>(LumberjackQueue);
            listBoxofLine.Items.Clear();
            foreach (Lumberjack lumber in AllLumberjackList)
            {
                listBoxofLine.Items.Add((AllLumberjackList.IndexOf(lumber)+ 1) + "." + lumber.Name);
            }
            if (LumberjackQueue.Count == 0)
            {
                groupBox1.Enabled = false;
                textBoxOfFlapjacksInfo.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = LumberjackQueue.Peek();
                textBoxOfFlapjacksInfo.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount
                  + " flapjacks";
            }

        }
        
    }
}
