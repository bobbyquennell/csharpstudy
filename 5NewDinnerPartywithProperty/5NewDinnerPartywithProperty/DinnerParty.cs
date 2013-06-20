using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _5NewDinnerPartywithProperty
{
    class DinnerParty
    {
        private const int CostPerPeople = 25;
        private int numOfPeople;
        public int NumOfPeople {
            get { return numOfPeople; }
            set { numOfPeople = value; }
            //tbd: calculate cost of decoration here }
        }
        private bool fancyDecoration;
        public DinnerParty(int numOfPeople, bool fancyDecoration, bool healtyOption) 
        {

        }

    }
}
