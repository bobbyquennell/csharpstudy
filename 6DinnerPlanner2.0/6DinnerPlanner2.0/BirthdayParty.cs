using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6DinnerPlanner2._0
{
    class BirthdayParty
    {
        private const decimal costPerPerson = 25M;
        private const decimal CakePrice8inches = 40M;
        private const decimal CakePrice16inches = 75M;
        private const decimal WritingPricePerCharacter = 0.25M;
        private int MaxCharacters;
        private int numOfPeople;
        public int NumOfPeople
        {
            get { return numOfPeople; }
            set { numOfPeople = value;
                  CalculateCostOfDecorations();
                  cakeSizeDecide(NumOfPeople);
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
                CalculateCostOfDecorations();

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
        private decimal costOfDecoration;
        public BirthdayParty(int numOfPeople,bool isFancyDeocration, string cakeWriting)
        {
            NumOfPeople = numOfPeople;
            CakeWriting = cakeWriting;
            IsFancyDecoration = isFancyDecoration;

            CalculateCostOfDecorations();
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
        private void CalculateCostOfDecorations()
        {
            if (IsFancyDecoration)
            {
                costOfDecoration = NumOfPeople * 15M + 50M;
            }
            else
            {
                costOfDecoration = NumOfPeople * 7.5M + 30M;
            }
        }
        public decimal CalculateCost()
        {
            decimal foodCost;
            foodCost = NumOfPeople * costPerPerson;
            CalculateCakePrice();
            CalculateCostOfDecorations();
            if (NumOfPeople > 12)
                return (foodCost + costOfCake + costOfDecoration + 100M);
            else
                return (foodCost + costOfCake + costOfDecoration);
        }

    }
}
