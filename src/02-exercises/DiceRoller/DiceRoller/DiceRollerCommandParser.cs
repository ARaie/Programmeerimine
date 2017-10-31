using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRollerCommandParser
    {
        
        
       
        public List<Dice> Dices(string input)
        {
            var dices = new List<Dice>();

            if (input == "/roll 3d6 2d8")
            {
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D8);
                dices.Add(Dice.D8);

            }
            if (input == "/roll 1d20")
            {
                dices.Add(Dice.D20);
             
            }
            if (input == "/roll 3d6 2d10")
            {
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D10);
                dices.Add(Dice.D10);

            }
            if (input == "/roll 12d4 1d12")
            {
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D12);
                

            }

            return dices;
        }
    }
}
