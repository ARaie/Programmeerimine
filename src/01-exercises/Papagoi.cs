using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papagoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan selle tagasi!");
            Console.WriteLine();
            Console.WriteLine("Sina ütled: ");

            string papagoi = Console.ReadLine();

            Console.WriteLine("Mina ütlen: "+papagoi);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();

        }

    }
}
