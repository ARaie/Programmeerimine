using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen programm Kalku. Ütle mulle kaks numbrit ja ma ütlen sulle mis on nende summa");
            Console.WriteLine();
            Console.Write("Esimene number: ");
            string esimenenr = Console.ReadLine();
            Console.Write("Teine number: ");
            string teinenr = Console.ReadLine();
            int üks = int.Parse(esimenenr);
            int kaks = int.Parse(teinenr);

            Console.Write("Tulemuseks on: "+(üks+kaks));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
