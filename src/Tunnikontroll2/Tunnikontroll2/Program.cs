using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST");
            Console.WriteLine("-----------------------");

            double sum = 0;

            while (true)
            {

                Console.Write("Enter price of good item [-1 to quit]: ");

                string input = Console.ReadLine();

                double i = double.Parse(input);

                Console.Write(i);

                if (i == -1)
                {
                    
                    break;
                }

                sum = sum + i;

               
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Subtotal: $ " + sum);
            double ale = sum * 0.15;
            Console.WriteLine("15.00 % Gratuity: $ " + ale);
            Console.WriteLine("Total: $ " + (sum - ale));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();


        }
    }
}
