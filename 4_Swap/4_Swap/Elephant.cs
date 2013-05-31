using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_Swap
{
    class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", Name + " says...");
        }
    }
}
