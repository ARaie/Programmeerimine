
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
            

            var cards = new List<Card> {
                new Card("4", Suite.Club, 4, false),
                new Card("6", Suite.Hearts, 6, false),
                new Card("8", Suite.Spade, 8, false),
                new Card("J", Suite.Diamond, 10, true),
                new Card("4", Suite.Spade, 4, false),
                new Card("T", Suite.Hearts, 10, true) };

            var deck = new Deck(cards);


            Console.WriteLine($"You have been dealt: {GetCardDercription(deck.Next())}, {GetCardDercription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDercription(deck.Next())}, {GetCardDercription(deck.Next())}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();
         
            Console.WriteLine($"You have been dealt: {GetCardDercription(deck.Next())}");

            Console.WriteLine($"House has been dealt: {GetCardDercription(deck.Next())}");
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

            //mingi list kus on kaardid ja ükshaaval võtta kaardi küljest punktid ja liita need kokku. oluline on ainult vahet teha kummad on minu ja kummad arvuti kaardid
        }
        public static string GetCardDercription ( Card card)
        {
            return card.Hidden ? "[?]" : card.Description;

        }
    }
}
