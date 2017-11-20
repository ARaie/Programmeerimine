using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRollerCommandParser
    {

      
        public List<Dice> Source(string input)
        {

            List<Dice> korrad = new List<Dice>();

            var dices = new List<Dice>();

            string täringud = input;
            string[] täring = täringud.Split(' ');
           
            foreach (var osa in täring)
            {
                var a = osa.Split('d')[0];
                int kordused = Int32.Parse(a); 
                string täringuSuurus = osa.Split('d')[1];
                korrad.Add(new Dice(kordused, täringuSuurus));        
            }


            foreach (var kord in korrad)
            {
                    Dice dice = Dice.FromString(kord.Description);

                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(dice);
                    }
                }

            return dices;
        }
    }
}
