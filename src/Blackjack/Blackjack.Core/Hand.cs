using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{

    public class Hand

    {
        public static void hand()
        {
            var totalMe = 0;
            var totalHouse = 0;

            List<Card> shuffledList = Deck.D52.Shuffle();

            totalMe = +Points.addPoints(shuffledList[0].Points) + Points.addPoints(shuffledList[1].Points);
            totalHouse = +Points.addPoints(shuffledList[2].Points) + Points.addPoints(shuffledList[3].Points);

            Deck shuffledDeck = new Deck(shuffledList);



            Console.WriteLine($"You have been dealt: {GetCardDercription(shuffledDeck.Next())}, {GetCardDercription(shuffledDeck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDercription(shuffledDeck.Next())}, {GetCardDercriptionInvisible(shuffledDeck.Next())}");
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
                    var addPoints = Points.addPoints(betsUp.Points);
                    totalMe = totalMe + addPoints;

                    var housePoints = shuffledDeck.Next();
                    Console.WriteLine($"House has been dealt: {GetCardDercriptionInvisible(housePoints)}");
                    var addHousePoints = Points.addPoints(housePoints.Points);
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
                    if (totalMe == 21)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine();
                    }

                    else if (totalMe > totalHouse && totalMe <= 21)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine();
                    }
                    else if (totalMe < totalHouse && totalHouse > 21)
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

        }
            public static string GetCardDercription(Card card)
            {

                return card.Description;

            }
        public static string GetCardDercriptionInvisible(Card card)
        {

            return card.Hidden ? "[?]" : card.Description;

        }

    }
}
