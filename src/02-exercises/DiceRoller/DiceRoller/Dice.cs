using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {

        public static readonly Random Random = new Random();

        public int Sides { get; }

        public string Description { get; }

     

        public Dice(int sides, string description)
        {

            this.Description = description;
            this.Sides = sides;

        }


        public static Dice FromString(string kirjeldus)
        {
            Dice dice = null;

            if (kirjeldus == "6")
            {
                dice = new Dice(6, "1d6");
            }
            else if (kirjeldus == "4")
            {
                dice = new Dice(4, "1d4");
            }
            else if (kirjeldus == "8")
            {
                dice = new Dice(8, "1d8");
            }
            else if (kirjeldus == "10")
            {
                dice = new Dice(10, "1d10");
            }
            else if (kirjeldus == "12")
            {
                dice = new Dice(12, "1d12");
            }
            else if (kirjeldus == "20")
            {
                dice = new Dice(20, "1d20");
            }
            return dice;
    }

        public int Roll()
        {
            return Dice.Random.Next(1, this.Sides + 1);
        }
    }
}

