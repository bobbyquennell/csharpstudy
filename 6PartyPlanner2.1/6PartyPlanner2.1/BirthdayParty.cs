using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6PartyPlanner2._1
{
    class BirthdayParty:Party
    {
        private const decimal CakePrice8inches = 40M;
        private const decimal CakePrice16inches = 75M;
        private const decimal WritingPricePerCharacter = 0.25M;
        private int MaxCharacters;
        //private int numOfPeople;
        override public int NumOfPeople
        {
            get { return numOfPeople; }
            set
            {
                numOfPeople = value;
                base.CalculateCostOfDecorations(base.IsFancyDecoration);
                base.CaculateCostOfFood();
                cakeSizeDecide(NumOfPeople);
            }
        }
        private int cakeSize;
        private string cakeWriting;
        public string CakeWriting
        {
            get
            {
                return cakeWriting;
            }
            set
            {
                if (value.Length > MaxCharacters)
                {
                    MessageBox.Show("the maximum characters is " + MaxCharacters.ToString(), "Error");
                }
                else
                {
                    cakeWriting = value;
                }

            }
        }
        private decimal costOfCake;
        public BirthdayParty(int numOfPeople, bool isFancyDeocration, string cakeWriting)
            :base(numOfPeople,isFancyDeocration)
        {
            CakeWriting = cakeWriting;
            CalculateCakePrice();
        }
        private void cakeSizeDecide(int personNum)
        {
            if (personNum <= 4)
            {
                cakeSize = 8;
                MaxCharacters = 16;
            }
            else
            {
                cakeSize = 16;
                MaxCharacters = 40;
            }
        }
        private void CalculateCakePrice()
        {
            decimal writingPrice;
            writingPrice = WritingPricePerCharacter * CakeWriting.Length;
            if (cakeSize == 8)
            {
                costOfCake = writingPrice + CakePrice8inches;
            }
            else if (cakeSize == 16)
            {
                costOfCake = writingPrice + CakePrice16inches;
            }
            else
            {
                MessageBox.Show("cakeSize error: " + cakeSize.ToString(), "Error Message");
            }

        }
        override public decimal CalculatePartyCost()
        {
            decimal TotalCost;
            CalculateCakePrice();
            TotalCost = base.CalculatePartyCost() + costOfCake;
            return TotalCost;
        }
    }
}
