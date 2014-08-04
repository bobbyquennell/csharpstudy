using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8BreakfastForLumberjacks
{
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount{ get{ return meal.Count;}}
        public void TakeFlapjacks(Flapjack Food, int HowMany)
        {
            //Add some number of flapjacks to the Meal stack
            for(int i = HowMany; i > 0 ; i--)
                meal.Push(Food);
        }
        public void EatFlapjacks()
        {
            // Write this output to the console
            Console.WriteLine(name + "'s eating flapjacks" + Environment.NewLine);
            while (meal.Count > 0)
            {
                Flapjack foodtoeat = meal.Pop();
                Console.WriteLine(name + " ate a " + foodtoeat.ToString().ToLower() 
                    + " flapjack" + Environment.NewLine);
            }
        }

    }
}
