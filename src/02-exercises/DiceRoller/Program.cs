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
            

            Console.WriteLine("Roll 3d6 2d8");
            Console.WriteLine();

            DiceRollerdiceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(new List<Dice> { DiceRoller.D6, DiceRoller.D6, DiceRoller.D6, Dice.D8, DiceRoller.D8 });


            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

           
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
