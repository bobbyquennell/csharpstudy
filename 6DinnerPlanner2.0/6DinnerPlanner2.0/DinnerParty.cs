using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6DinnerPlanner2._0
{
    class DinnerParty
    {
        private const decimal CostPerPeople = 25;
        private int numOfPeople;
        public int NumOfPeople {
            get 
            { 
                return numOfPeople; 
            }
            set 
            { 
                numOfPeople = value;
                calculateDecoration();
            }
        }
        private bool fancyDecoration;
        public bool FancyDecoration
        {
            get
            {
                return fancyDecoration;
            }
            set 
            {
                fancyDecoration = value;
                calculateDecoration();
            }
        }
        private decimal costOfDecoration;
        public bool HealthyOption { get; set; }
        public DinnerParty(int numOfPeople, bool fancyDecoration, bool healtyOption) 
        {
            NumOfPeople = numOfPeople;
            this.fancyDecoration = fancyDecoration;
            HealthyOption = healtyOption;
            calculateDecoration();
            //constructor
        }
        private void calculateDecoration()
        {
            if (fancyDecoration)
            {
                costOfDecoration = (decimal)NumOfPeople * 15m + 50m;
            }
            else
            {
                costOfDecoration = (decimal)NumOfPeople * 7.5m + 30m;
            }
        }
        public decimal GetPartyCost()
        {
            decimal TotalCost = 0m;
            if (HealthyOption)
	        {
                TotalCost = costOfDecoration + (decimal)NumOfPeople * (CostPerPeople + 5m) * 0.95m;
		 
	        }
            else
            {
                TotalCost = costOfDecoration + (decimal)NumOfPeople * (CostPerPeople + 20m);
            }
            if (NumOfPeople > 12)
            {
                return TotalCost + 100M;
            }
            else
                return TotalCost;
        }

    }
}
