using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewelThief
{
    class Program
    {
        static void Main(string[] args)
        {
            Safe mySafe = new Safe();
            Owner Bobby = new Owner();
            JewelThief Anddic = new JewelThief();
            Anddic.OpenSafe(mySafe, Bobby);
            Console.ReadKey();
        }
    }
}
