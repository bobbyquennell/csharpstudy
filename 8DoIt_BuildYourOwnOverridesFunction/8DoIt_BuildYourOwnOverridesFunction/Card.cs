using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8DoIt_BuildYourOwnOverridesFunction
{
    public enum Suit
    {
        Spades = 0,
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
    };
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
        public static Boolean DoesCardMatch(Suit suit1, Suit suit2)
        {
            if (suit1 == suit2)
            {
                return true;
            }
            else
                return false;
        }
        public static Boolean DoesCardMatch(Value value1, Value value2)
        {
            if (value1 == value2)
            {
                return true;
            }
            else
                return false;

        }
    }
}
