using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Sloppy_Joe
{
    class MenuMaker
    {
        public Random Randomrizer;
        public string[] Meats = {"Roast beef", "Salami", "Turkey", "Ham", "Pastrami"};
        public string[] Condiments = {"yellow mastard", "brown mustard", 
                                     "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = {"rye", "white", "wheat", "pumpernickel",
                                 "italian bread", "a roll"};
        public string GetMenumItem()
        {
            string meat = Meats[Randomrizer.Next(Meats.Length)];
            string condiment = Condiments[Randomrizer.Next(Condiments.Length)];
            string bread = Breads[Randomrizer.Next(Breads.Length)];
            return meat + " with " + condiment + " on " + bread;
 
        }
    }
}
