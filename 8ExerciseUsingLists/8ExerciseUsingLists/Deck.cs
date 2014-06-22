using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8ExerciseUsingLists
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();
        public Deck()
        { //default constructor
            cards = new List<Card>();
            //if no parameters input, create a full deck of 52 cards.
            for (int suit = 0; suit < 4; suit++)
                for (int value = 1; value < 14; value++)
                    cards.Add(new Card((Suit)suit, (Value)value));

        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public void Shuffle()
        {
            // this method shuffles the cards by rearranging them in a random order
            List<Card> shuffledCards = new List<Card>();
            int length = cards.Count;
            for (int i = length -1; i >= 0; i--)
            {
                shuffledCards.Add(Deal(random.Next(cards.Count)));
            }
            cards.AddRange(shuffledCards);
            
        }
        public IEnumerable<string> GetCardName(){
            //this method returns a string array that contains each card's name
            List<string> CardsName = new List<string>();
            foreach (Card eachcard in cards)
                CardsName.Add(eachcard.Name);

            return CardsName;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuitThenValue()); 
           
        }

    }
}