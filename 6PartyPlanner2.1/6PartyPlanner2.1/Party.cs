using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6PartyPlanner2._1
{
    class Party
    {
        private const decimal FoodCostPerPeople = 25M; 
        protected int numOfPeople;
        virtual public int NumOfPeople
        {
            get
            {
                return numOfPeople;
            }
            set
            {
                numOfPeople = value;
                CaculateCostOfFood();
                CalculateCostOfDecorations(IsFancyDecoration);
            }
        }
        private bool isFancyDecoration;
        public bool IsFancyDecoration
        {
            get
            {
                return isFancyDecoration;
            }
            set
            {
                isFancyDecoration = value;
                CalculateCostOfDecorations(isFancyDecoration);

            }
        }
        private decimal costOfDecoration;
        protected void CalculateCostOfDecorations(bool ifFancyDecoration)
        {
            if (ifFancyDecoration)
            {
                costOfDecoration = NumOfPeople * 15M + 50M;
            }
            else
            {
                costOfDecoration = NumOfPeople * 7.5M + 30M;
            }
        }
        private decimal costOfFood;
        protected void CaculateCostOfFood()
        {
            costOfFood = NumOfPeople * FoodCostPerPeople;
        }
        virtual public decimal CalculatePartyCost()
        {
            //CaculateCostOfFood();
            //CalculateCostOfDecorations(IsFancyDecoration);
            if (NumOfPeople > 12)
                return (costOfFood + costOfDecoration + 100M);
            else
                return (costOfFood + costOfDecoration);
        }
        public Party(int numOfPeople, bool isFancyDecoration)
        {
            NumOfPeople = numOfPeople;
            IsFancyDecoration = isFancyDecoration;
        }

    }
}
