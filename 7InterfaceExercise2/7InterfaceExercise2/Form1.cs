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
            //solution A: this solution is used to show upcasting and downcasting
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;//upcasting to FunnyFunny Class
            IScaryClown  someOtherScaryClown = someFunnyClown as ScaryScary;//downcasting to IScaryClown interface
            
            //if (someFunnyClown is IScaryClown) //my solution 1 which is different to the book, using interface casting with "as IScaryClown"
            //{
                //IScaryClown someOtherScaryClown = someFunnyClown as IScaryClown;
                //someOtherScaryClown.Honk();
            //}

            //solution 2: just one statement is enough
            //IScaryClown someOtherScaryClown = new ScaryScary("big shoes", 14);
            someOtherScaryClown.Honk();
            //someFunnyClown.Honk();
            
        }
    }
}
