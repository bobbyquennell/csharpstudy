﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8LongExercise_GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            //The constructor for the Player class ininitializes four private fields, and then
            //adds a line to the TextBox control on the form that says, "Joe has just
            // joined the game" -but use the name in the private field, and don't forget to
            // add a line break at the end of every line you add to the TextBox.
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new List<Card>());
            this.textBoxOnForm.Text += this.name + " has just joined the game\r\n";
        }
        public IEnumerable<Value> PullOutBooks() {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                    {
                        cards.Deal(card);
                    }
                }
            }

            return books;
        }

        public Value GetRandomValue()
        {
            //This method gets a random value - but it has to be a value that's in the deck!
            Value getValue;
             do
	        {
                 getValue = (Value)(random.Next(1,14));
	         
	        } while (!cards.ContainsValue(getValue));
            //this algorithm is low in efficency, need to enhance it later
             return getValue;
        }
        public Deck DoYouHaveAny(Value value)
        {
            //This is where an opponent asks if I have any cards of a certain value
            //Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
            //that says, "Joe has 3 sixes" -use the new Card.Plural() static method
            Deck cardcheck = cards.PullOutValues(value);
            if(cardcheck.Count > 1)
                this.textBoxOnForm.Text += this.Name + " has " + cardcheck.Count + " " + Card.Plural(value) + "\r\n";
            else
                this.textBoxOnForm.Text += this.Name + " has " + cardcheck.Count + " " + value + "\r\n";

            return cardcheck;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            //Here's an overloaded version of AskForACard() -choose a random value
            //from the deck using GetRandomValue() and ask for it using AskForACard()
            AskForACard(players, myIndex, stock, GetRandomValue());
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value value)
        {
            //Ask the other players for a value. First add a line to the TextBox: "Joe asks
            // if anyone has a Queen". Then go through the list of players that was passed in
            //as a parameter and ask each player if he has any of the value (using his
            // DoYouHaveAny() method). He'll pass you a deck of cards - add them to my deck.
            // Keep track of how many cards were added. If there weren't any, you'll need 
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // add you'll have to add a line to the TextBox: "Joe had to draw from the stock"
            int TotalCount = 0;
            //int PlayerIndex = 0;
            this.textBoxOnForm.Text += this.Name + " asks if anyone has a " + value.ToString() + "\r\n";
            foreach (Player PlayerToAsk in players)
            {
                if (myIndex != players.IndexOf(PlayerToAsk))
                {

                    Deck getCards = PlayerToAsk.DoYouHaveAny(value);
                    if (getCards.Count > 0)
                    {
                        TotalCount += getCards.Count;
                        for (int i = getCards.Count; i > 0; i--)
                            cards.Add(getCards.Deal(i - 1));
                    }
                }
                
            }
            if (TotalCount == 0)
            {
                if(stock.Count > 0)
                    cards.Add(stock.Deal());
                this.textBoxOnForm.Text += this.Name + " had to draw from the stock" + "\r\n";
            }
                
        }
        //Here's a property and a few short method that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card cardToTake) { cards.Add(cardToTake); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardName(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
    public partial class Card
    {
        public static string Plural(Value value)
        {
            if (value == Value.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
