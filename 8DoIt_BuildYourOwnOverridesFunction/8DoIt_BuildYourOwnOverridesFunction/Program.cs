using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8DoIt_BuildYourOwnOverridesFunction
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
            Card myCard = new Card(Suit.Diamonds, Value.King);
            bool isCardMatch = Card.DoesCardMatch(myCard.Suit, Suit.Diamonds);
            Console.WriteLine(isCardMatch.ToString());
            isCardMatch = Card.DoesCardMatch(myCard.Value, Value.Jack);
            Console.WriteLine(isCardMatch.ToString());
            Console.WriteLine("Press \"Enter\" to quit....");
            Console.ReadLine();

        }
    }
}
