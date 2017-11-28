
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
            var totalMe = 0;
            var totalHouse = 0;

            var cards = new List<Card> {
                new Card("4", Suite.Club, 4, true),
                new Card("6", Suite.Hearts, 6, true),
                new Card("8", Suite.Spade, 8, true),
                new Card("J", Suite.Diamond, 10, true),
                new Card("4", Suite.Spade, 4, true),
                new Card("T", Suite.Hearts, 10, true),
                new Card("5", Suite.Spade, 5, true),
                new Card("3", Suite.Spade, 3, true),
                new Card("2", Suite.Hearts, 2, true),
                new Card("7", Suite.Hearts, 7, true)};


            Deck deck = new Deck(cards);
            List<Card> shuffledList = deck.Shuffle();

             totalMe = +shuffledList[0].Points + shuffledList[1].Points;
             totalHouse = +shuffledList[2].Points + shuffledList[3].Points;
         
            Deck shuffledDeck = new Deck(shuffledList);



            Console.WriteLine($"You have been dealt: {GetCardDercription(shuffledDeck.Next())}, {GetCardDercription(shuffledDeck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDercription(shuffledDeck.Next())}, {GetCardDercription(shuffledDeck.Next())}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();
            bool correct = false;

            while (!correct)
            {
                string option = Console.ReadLine();
                Console.WriteLine("I choose: " + option);
                Console.WriteLine();

                if (option == "1")
                {
                    var betsUp = shuffledDeck.Next();
                    Console.WriteLine($"You have been dealt: {GetCardDercription(betsUp)}");
                    var addPoints = betsUp.Points;
                    totalMe = totalMe + addPoints;

                    var housePoints = shuffledDeck.Next();
                    Console.WriteLine($"House has been dealt: {GetCardDercription(housePoints)}");
                    var addHousePoints = housePoints.Points;
                    totalHouse = totalHouse + addHousePoints;

                    Console.WriteLine();
                    Console.WriteLine("What do you want to do? ");
                    Console.WriteLine("Choose [1] to take another card");
                    Console.WriteLine("Choose [2] to finish");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You have " + totalMe + " points vs house have " + totalHouse + " points");
                    if(totalMe == 21)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine();
                    }

                    else if (totalMe > totalHouse && totalMe <= 21)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("House win!");
                        Console.WriteLine();

                    }
                }
            }
            

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            
        }
        public static string GetCardDercription(Card card)
        {
            
            return card.Description + Convert.ToString(card.Points);

        }
        // For user -> to hide House cards
        public static string GetCardDercriptionInvisible(Card card)
        {

            return card.Hidden ? "[?]" :  card.Description + Convert.ToString(card.Points);

        }
       
    }
}
