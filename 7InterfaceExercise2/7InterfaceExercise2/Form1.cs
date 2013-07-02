using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7InterfaceExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallguy = new TallGuy() {Height = 74, Name = "Jimmy"};
            tallguy.TalkAboutYourself();
            tallguy.Honk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;//upcasting to FunnyFunny Class
            IScaryClown  someOtherScaryClown = someFunnyClown as ScaryScary;//downcasting to ScaryScary Class
            
            //if (someFunnyClown is IScaryClown) //my solution which is different to the book, using interface casting with "as IScaryClown"
            //{
                //IScaryClown someOtherScaryClown = someFunnyClown as IScaryClown;
                //someOtherScaryClown.Honk();
            //}
            someOtherScaryClown.Honk();
            //someFunnyClown.Honk();
            
        }
    }
}
