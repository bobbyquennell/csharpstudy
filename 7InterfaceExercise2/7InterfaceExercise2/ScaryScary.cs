using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7InterfaceExercise2
{
    class ScaryScary:FunnyFunny,IScaryClown
    {
        private int numberOfScaryThings;

        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders"; }
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha!");
        }
        public ScaryScary(string FunnyThingIHave, int numberOfScaryThings)
            : base(FunnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
    }
}
