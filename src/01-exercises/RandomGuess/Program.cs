using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe numbri  [1-100], proovi see ära arvata!");
            int number = new Random().Next(1, 101);

            while (true)
            {
                Console.WriteLine("Sina pakud: ");
                String pakkumine = Console.ReadLine();
                int arvamine = int.Parse(pakkumine);

                if (arvamine == number)
                {
                    Console.WriteLine("Hea töö! See oligi minu valitud number!");
                    break;
                }
                else if (arvamine > number)
                {
                    Console.WriteLine("Minu valitud number on väiksem");

                }
                else
                {
                    Console.WriteLine("Minu valitud number on suurem");
                }
            }

            

            
            
            
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
