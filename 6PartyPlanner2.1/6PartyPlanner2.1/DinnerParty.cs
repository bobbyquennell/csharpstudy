using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6PartyPlanner2._1
{
    class DinnerParty:Party
    {
        private double specialDiscount;
        private decimal costOfbeveragePerperson;
        private bool healthyOption;
        public bool HealthyOption 
        {
            get
            { return healthyOption; }
            set
            {
                healthyOption = value;
                if (HealthyOption)
	            {
                    specialDiscount = 0.95;
                    costOfbeveragePerperson = 5M;
	            }
                else
	            {
                    specialDiscount = 1;
                    costOfbeveragePerperson = 20M;
	            }
             } 
        }
        
        public DinnerParty(int numOfPeople, bool fancyDecoration, bool healtyOption)
            :base(numOfPeople, fancyDecoration)
        {
            HealthyOption = healtyOption;
        }

        override public decimal CalculatePartyCost()
        {
            decimal TotalCost = 0m;
            TotalCost = base.CalculatePartyCost();
            TotalCost += costOfbeveragePerperson * NumOfPeople;
            TotalCost *= (decimal)specialDiscount;
            return TotalCost;
        }
    }
}
