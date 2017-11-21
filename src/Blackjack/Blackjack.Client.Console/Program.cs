
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

            var c4 = new Card("4", Suite.Club, 4);
            c4.Hidden = false;
            var h6 = new Card("6", Suite.Hearts, 6);
            h6.Hidden = false;
            var s8 = new Card("8", Suite.Spade, 8);
            s8.Hidden = false;
            var dJ = new Card("J", Suite.Diamond, 10);

            Console.WriteLine($"You have been dealt: {GetCardDercription(c4)}, {GetCardDercription(h6)}");
            Console.WriteLine($"House has been dealt: {GetCardDercription(s8)}, {GetCardDercription(dJ)}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            var s4 = new Card("4", Suite.Spade, 4);
            s8.Hidden = false;

            Console.WriteLine($"You have been dealt: {GetCardDercription(s4)}");

            var hT = new Card("T", Suite.Hearts, 10);

            Console.WriteLine($"House has been dealt: {GetCardDercription(hT)}");
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
        public static string GetCardDercription ( Card card)
        {
            return card.Hidden ? "[?]" : card.Description;

        }
    }
}
