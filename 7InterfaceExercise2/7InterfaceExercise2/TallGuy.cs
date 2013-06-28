using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7InterfaceExercise2
{
    class TallGuy
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself() {
            MessageBox.Show("My name is: " + Name + " and I'm " 
                + Height + " inches tall.");
        }
    }
}
