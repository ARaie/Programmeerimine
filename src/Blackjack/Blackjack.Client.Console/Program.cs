
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Client.Console
{
    using System;
    using Blackjack.Core;

    class Program
    {
        static void Main(string[] args)
        {
            //All aces are 11 points, when user graws a card, house always draws a card. 

            Console.WriteLine("Welcome to the came!");
            Console.WriteLine();

            var c4 = new Card("4", 'C', 4);
            var h6 = new Card("6", 'H', 6);
            var s8 = new Card("8", 'S', 8);
            var dJ = new Card("J", 'D', 10);

            Console.WriteLine($"You have been dealt: {c4.Description} ,{h6.Description}");
            Console.WriteLine($"House has been dealt: {s8.Description}, {(dJ.Hidden ? "[?]" : dJ.Description)}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();
            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House has been dealt: [?]");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine("You have 14 points vs house have 17 points");
            Console.WriteLine("House win!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
