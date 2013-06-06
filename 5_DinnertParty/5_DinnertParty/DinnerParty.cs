using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_DinnertParty
{
    class DinnerParty
    {
        private int NumOFPeople = 5;
        private decimal BeverageCostPerPerson;
        public const int CostsOfFoodPerPerson = 25;
        public decimal TotalDecoCost = 0;

        public void SetHealthyOption(bool IsHealthy)
        {
            if (IsHealthy) {
                BeverageCostPerPerson = 5;

            }
            else {
                BeverageCostPerPerson = 20;
            }

        }
        public void CalculateDecorationCosts(bool IsFancyDec)
        {
            if (!IsFancyDec) {
                TotalDecoCost = NumOFPeople * 7.5M + 30M;
            }
            else {
                TotalDecoCost = NumOFPeople * 15M + 50M;
            }

        }
        public decimal CalculateCosts()
        {
            decimal TotalCost = 0;
            TotalCost = NumOFPeople * (CostsOfFoodPerPerson + BeverageCostPerPerson) + TotalDecoCost;
            if (BeverageCostPerPerson == 5) {
                TotalCost = TotalCost * 0.95M;
            }

            return TotalCost;
        }
        public void SetPartyOptions(int people, bool fancy)
        {
            NumOFPeople = people;
            CalculateDecorationCosts(fancy);
        }
        public int GetNumOfPeople()
        {
            return NumOFPeople;
        }
    }
    }

