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
        private decimal costOfDecoration;
        public BirthdayParty(int numOfPeople,bool isFancyDeocration, string cakeWriting)
        {
            NumOfPeople = numOfPeople;
            cakeChoose(NumOfPeople, cakeWriting);
            IsFancyDecoration = isFancyDecoration;

            CalculateCostOfDecorations();
        }
        private void cakeChoose(int personNum,string cakeWriting)
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
            if (cakeWriting.Length > MaxCharacters)
            {
                MessageBox.Show("Error", "the maximum characters is" + MaxCharacters.ToString());
            }
            else
            {
                this.cakeWriting = cakeWriting;
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
                costOfDecoration = NumOfPeople * 7.5M + 30;
            }
        }
        public int CalculateCost()
        {
            decimal TotalCost;
            decimal CakePrice;
            if ()
            {
                
            }

            return 1;
        }

    }
}
