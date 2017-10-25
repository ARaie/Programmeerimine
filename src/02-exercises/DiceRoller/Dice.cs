using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        private Random Random { get; }

        private int Sides { get; }

        public String description { get; }

        private static readonly Random Random = new Random();
        

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            this.description = description;
            this.Random = new Random();
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");


        public int Roll () 
        {

            return this.Random.Next(1, this.Sides + 1);
           
        }
          
    }
}
