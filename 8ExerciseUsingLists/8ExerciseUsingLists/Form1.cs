using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8ExerciseUsingLists
{
    public partial class Form1 : Form
    {
        Deck deck1, deck2;
        public Form1()
        {
            Deck decktoDeal;
            List<Card> cardsofDeck1 = new List<Card>();
            decktoDeal = new Deck();
            Random random = new Random();
            int Deck1Count = random.Next(1,11);
            for (int i = 0; i < Deck1Count; i++)
                cardsofDeck1.Add(decktoDeal.Deal(random.Next(decktoDeal.Count)));
            deck1 = new Deck(cardsofDeck1);
            deck1.Sort();
            //RedrawDeck(1);
            deck2 = new Deck();
            deck2.Sort();
            //RedrawDeck(2);
            InitializeComponent();
            foreach (string cardName in deck1.GetCardName())
                listBox1.Items.Add(cardName);
            label1.Text = "Deck #1(" + deck1.Count + " cards)";

            foreach (string cardName in deck2.GetCardName())
                listBox2.Items.Add(cardName);
            label2.Text = "Deck #2(" + deck2.Count + " cards)";
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;

        }

        private void Button_MoveToDeck2_Click(object sender, EventArgs e)
        {
            deck2.Add(deck1.Deal(listBox1.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void Button_MoveToDeck1_Click(object sender, EventArgs e)
        {
            deck1.Add(deck2.Deal(listBox2.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void button_ResetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
        }

        private void button_ResetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
        }

        private void button_ShuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void button_ShuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardName())
                    listBox1.Items.Add(cardName);
                label1.Text = "Deck #1(" + deck1.Count + " cards)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardName())
                    listBox2.Items.Add(cardName);
                label2.Text = "Deck #2(" + deck2.Count + " cards)";
            }
        }
        public void ResetDeck(int DeckNum)
        {
            if (DeckNum == 1)
            {
                int deck1count = deck1.Count;
                for (int i = deck1count-1; i >= 0; i--)
                    deck1.Deal(i);


                Deck decktoDeal;
                List<Card> cardsofDeck1 = new List<Card>();
                decktoDeal = new Deck();
                Random random = new Random();
                int Deck1Count = random.Next(1, 11);
                for (int i = 0; i < Deck1Count; i++)
                    cardsofDeck1.Add(decktoDeal.Deal(random.Next(decktoDeal.Count)));
                deck1 = new Deck(cardsofDeck1);
                deck1.Sort();
                RedrawDeck(1);
            }
            else
            {
                int deck2count = deck2.Count;
                for (int deck2index = deck2count - 1; deck2index >= 0; deck2index--)
                    deck2.Deal(deck2index);

                deck2 = new Deck();
                deck2.Sort();
                RedrawDeck(2);
            }
        }



    }
}
