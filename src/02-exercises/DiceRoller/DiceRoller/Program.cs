using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Ütle mida veeretada tahad");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("> "+input);
            Console.WriteLine();


            DiceRollerCommandParser dices = new DiceRollerCommandParser();
            List<Dice> f = dices.Dices(input);

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(f);

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"{diceRoll.Dice}: {diceRoll.Value}");
            }


            /*
            Dice d6 = Dice.D6;
            var total = 0;

            for (var i =0; i<3; i++)
            {
                var roll = d6.Roll();
                total += roll;

                Console.WriteLine($"{d6.Description}: {roll}");
            }

            Dice d8 = Dice.D8;

            for (var i = 0; i < 2; i++)
            {
               var roll = d8.Roll();
                total += roll;

                Console.WriteLine($"{d8.Description}: {roll}");
            }
            
    */
            Console.WriteLine();
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.WriteLine(">");
            Console.ReadLine();
        }
    }
}
