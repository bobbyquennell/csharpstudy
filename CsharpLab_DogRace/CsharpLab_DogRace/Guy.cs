using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CsharpLab_DogRace
{
    class Guy
    {
        public string Name;//The Guy's name
        public Bet MyBet;// An instance of Bet() that has his bet
        public int Cash;//How much cash he has

        // these two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton; 
        public Label MyLabel;

        public void UpdateLabels()
        {
            // set my label to my bet's description. and the label on my
            // radio button to show my cash("Joe has 43 bucks")
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                MyLabel.Text = Name + " hasn't placed a bet";
            }
            
        }
        public bool PlaceBet(int BetAmount, int DogNum)
        {
            //place a new bet and store it in my bet field
            MyBet = new Bet();
            // return true if the guy had enough money to bet
            if (Cash >= BetAmount)
            {
                MyBet.Amount = BetAmount;
                MyBet.Dog = DogNum;
                MyBet.Bettor = this;
                return true;
            }
            else
            {
                MyBet.Amount = 0;
                MyBet.Dog = DogNum;
                MyBet.Bettor = this;
                return false;
            }
        }
        public void ClearBet()
        { 
            // Reset my bet so it's zero
            MyBet = null;
        }
        public void Collect(int winner)
        { // Ask my bet to pay out
            if (MyBet != null)
            {
                Cash += MyBet.Payout(winner);
            }

        }
    }
}
