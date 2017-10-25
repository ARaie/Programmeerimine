using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hei kirjuta oma summa siia...");

            String summa = Console.ReadLine();
            int summa1 = int.Parse(summa);

            if (summa1 > 50)
            {
                double a = (summa1 * 0.05);
                Console.WriteLine("Sinu sisestatud summa oli "+summa1+" selle summa pealt sai soodustust 5 % ja soodushind sulle on "+ (summa1-a));
            }
            if (summa1 > 250)
            {
                double a = (summa1 * 0.1);
                Console.WriteLine("Sinu sisestatud summa oli " + summa1 + " selle summa pealt sai soodustust 10 % ja soodushind sulle on " + (summa1 - a));
            }
            if (summa1 > 500)
            {
                double a = (summa1 * 0.2);
                Console.WriteLine("Sinu sisestatud summa oli " + summa1 + " selle summa pealt sai soodustust 20 % ja soodushind sulle on " + (summa1 - a));
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}
