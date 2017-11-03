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
            Console.WriteLine("Give your command");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("> /roll "+input);
            Console.WriteLine();


            DiceRollerCommandParser dices = new DiceRollerCommandParser();
            List<Dice> userCommand = dices.Source(input);

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(userCommand);

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"{diceRoll.Dice}: {diceRoll.Value}");
            }
       
            Console.WriteLine();
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.WriteLine(">");
            Console.ReadLine();
        }
    }
}
