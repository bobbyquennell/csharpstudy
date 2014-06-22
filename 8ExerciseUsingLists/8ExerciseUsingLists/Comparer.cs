using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8ExerciseUsingLists
{
    class CardComparer_bySuit:IComparer<Card>
    {
        public int Compare(Card card1, Card card2){
            if (card1.Suit > card2.Suit)
            {
                return 1;
            }
            else if (card1.Suit == card2.Suit)
            {
                return 0;
            }
            else
                return -1;
        }
    }
    class CardComparer_byValue:IComparer<Card>
    {
        public int Compare(Card card1, Card card2)
        {
            if (card1.Value > card2.Value)
            {
                return -1;
            }
            else if (card1.Value == card2.Value)
            {
                return 0;
            }
            else
                return 1;
        }
    }
    class CardComparer_bySuitThenValue : IComparer<Card>
    {
        public int Compare(Card card1, Card card2)
        {
            if (card1.Suit > card2.Suit)
            {
                return 1;
            }
            else if (card1.Suit == card2.Suit)
            {
                if (card1.Value > card2.Value)
                {
                    return 1;
                }
                else if (card1.Value == card2.Value)
                {
                    return 0;
                }
                else
                    return -1;
            }
            else
                return -1; 

        }
    }
}
