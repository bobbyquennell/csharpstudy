using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8DoIt_ListsShrinkGrowDynamically
{
    class Program
    {
        static void Main(string[] args)
        {
            List<shoe> shoeCloset = new List<shoe>();
            shoeCloset.Add(new shoe() {Style = Style.Sneakers, Color = "Black"});
            shoeCloset.Add(new shoe() { Style = Style.Clogs, Color = "Brown" });
            shoeCloset.Add(new shoe() { Style = Style.Wingtips, Color = "Black" });
            shoeCloset.Add(new shoe() { Style = Style.Loafers, Color = "White" });
            shoeCloset.Add(new shoe() { Style = Style.Loafers, Color = "Red" });
            shoeCloset.Add(new shoe() { Style = Style.Sneakers, Color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;   
                shoe.Color = "Orange";
            }

            shoeCloset.RemoveAt(4);
            shoe ThirdShoe = shoeCloset[3];
            shoe SecondShoe = shoeCloset[2];
            shoeCloset.Clear();
            shoeCloset.Add(ThirdShoe);
            if(shoeCloset.Contains(SecondShoe))      
                Console.WriteLine("That's suprising!");



        }
    }
    enum Style
    {
        Sneakers,
        Clogs,
        Wingtips,
        Flipflops,
        Loafers,
        Sandals,

    }

    // enum Color
    //{
    //    Black,
    //    Brown,
    //    White,
    //    Red,
    //    Green,
    //}
    class shoe
    {

        public Style Style { get; set; }
        public string Color { get; set; }

        
    }
}
