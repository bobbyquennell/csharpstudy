using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7InterfaceExercise2
{
    class FunnyFunny:IClown
    {
        private string funnyThingIHave;
        public FunnyFunny(string FunnyThingIHave)
        {
            funnyThingIHave = FunnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get { return "Honk honk! I have a " + funnyThingIHave; }
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);//The Honk()
                                                //method just uses
                                                //this set accessor
                                                //to display its
                                                //message—no need
                                                //to have the same
                                                //code twice.
        }
    }
}
