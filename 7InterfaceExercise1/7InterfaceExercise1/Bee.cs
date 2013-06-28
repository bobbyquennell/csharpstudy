using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7InterfaceExercise1
{
    class Bee:IStingPatrol
    {
        public int SharpenStinger(int Stingerlength)
        { return Stingerlength; }
        public bool LookForEnemies()
        { return true; }
        public int StingerLength 
        { 
            get; 
            set; 
        }
        public int AlertLevel 
        {
            get
            { return 1; }
            //set; 
        }

    }
}
