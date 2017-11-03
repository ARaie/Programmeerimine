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
        public static Dice D6 = new Dice(6, "1d6");
 
         public static Dice D8 = new Dice(8, "1d8");
 
         public static Dice D20 = new Dice(20, "1d20");
 
         public static Dice D10 = new Dice(10, "1d10");
 
         public static Dice D4 = new Dice(4, "1d4");
 
         public static Dice D12 = new Dice(12, "1d12");
 

        public static Dice FromString(string kirjeldus)
        {
            

            if (kirjeldus == "6")
            {
                return  D6;
            }
            else if (kirjeldus == "4")
            {
                return D4;
            }
            else if (kirjeldus == "8")
            {
                return D8;
            }
            else if (kirjeldus == "10")
            {
                return D10;
            }
            else if (kirjeldus == "12")
            {
               return D12;
            }
            else 
            {
                return D20;
            }
           
    }

        public int Roll()
        {
            return Dice.Random.Next(1, this.Sides + 1);
        }
    }
}

