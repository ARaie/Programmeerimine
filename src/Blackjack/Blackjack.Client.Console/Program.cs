
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
            //All aces are 11 points, when user draws a card, house always draws a card. 

            Console.WriteLine("Welcome to the came!");
            Console.WriteLine();
            
            Hand.hand();
        
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            
        }
        
        
    }
    
}
