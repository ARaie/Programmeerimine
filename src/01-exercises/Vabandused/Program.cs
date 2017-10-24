using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vabandused
{
    class Program
    {
        static void Main(string[] args)
        {
            var vabandused = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutis istuda" };

            int i = 0;
            foreach (var vabandus in vabandused)
            {
                Console.WriteLine($"{i+1}. {vabandus}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
