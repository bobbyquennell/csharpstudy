using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6BeehiveManagementSystem2_0
{
    class Bee
    {
        private int weight;
        //private int shiftsLeft;
        virtual public int ShiftsLeft
        {
            //get;
            get { return 0; }
            //set { ShiftsLeft = shiftsLeft; }
            //set;
        }
        virtual public double GetHoneyConsumption()
        {
            double HoneyConsumption;
            if (ShiftsLeft == 0)// no work is doing 
                HoneyConsumption = 7.5;
            else
                HoneyConsumption = ShiftsLeft + 9;
            if (weight > 150)
                HoneyConsumption *= 1.35;
            return HoneyConsumption;
        }
        public Bee(int beeWeight)
        {
            weight = beeWeight;
        }
    }
}
