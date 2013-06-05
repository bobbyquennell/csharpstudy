using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace CsharpLab_DogRace
{
    class Bet
    {
        public int Amount;// the amount of money that was bet
        public int Dog;// The number of the dog the bet is on
        public Guy Bettor;// The guy who placed the bet

        public string GetDescription()
        {   
            //return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4" ). If the amount is zero, no bet was placed
            //("Joe hasn't placed a bet").
            string msg = "";
            if (Amount == 0)
            {
                msg = Bettor.Name + " hasn't placed a bet";
            }
            else
            {
                msg = Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            return msg;
        }
        public int Payout(int Winner)
        { 
            // the parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of 
            // the amount bet.
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
