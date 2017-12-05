
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Client.Console
{
    using System;
    using Blackjack.Core;

    public class Program
    {
        static void Main(string[] args)
        {
            //All aces are 11 points, when user draws a card, house always draws a card. 

                Console.WriteLine("Welcome to the came!");
                Console.WriteLine();
                Console.WriteLine("Do you want to play card deck with 36 cards or card deck with 52 cards? ");
                string input = Console.ReadLine();
                Console.WriteLine();

            // Class Hand is little overloaded, it holds cards and calculates player and house points
            Hand.CalculatePoints(input);

                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            
           
        }
        
    }
}
