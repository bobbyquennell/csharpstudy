using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Create5CardsAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> myCards = new List<Card>{
            
                new Card((Suit)(random.Next(4)),(Value)(random.Next(1,14))),
                new Card((Suit)(random.Next(4)),(Value)(random.Next(1,14))),
                new Card((Suit)(random.Next(4)),(Value)(random.Next(1,14))),
                new Card((Suit)(random.Next(4)),(Value)(random.Next(1,14))),
                new Card((Suit)(random.Next(4)),(Value)(random.Next(1,14))),
            };
            foreach (Card card in myCards)
            {
                Console.WriteLine(card.Name);
            }

            
            ComparerCards myComparer = new ComparerCards();
            myComparer.SortMethod = SortCriteria.ValueThenSuits;
            myCards.Sort(myComparer);
            Console.WriteLine();
            foreach (Card card in myCards)
            {
                Console.WriteLine(card.Name);
            }


            Console.ReadKey();

        }
    }
}
