using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5CowCalculator
{
    class Farmer
    {
        //public int BagsOfFeed;
        public int BagsOfFeed { get; private set; }
        public const int FeedMultiplier = 30;
        private int numberOfCows;
        public int NumberOfCows {

            get {
                return numberOfCows;
            }
            set {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
