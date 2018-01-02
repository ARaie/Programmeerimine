using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{

    public class Hand

    {
        public static void CalculatePoints(string userInput)
        {

            var totalMe = 0;
            var totalHouse = 0;
            var houseCards = new List<string>();

            // When user choose deck size, the right list is created
            List<Card> shuffledList = Deck.List(userInput);

            // Adds player and house first cards points, these cards are dealt by default when the game starts
            totalMe = +Points.addPoints(shuffledList[0].Points) + Points.addPoints(shuffledList[1].Points);
            totalHouse = +Points.addPoints(shuffledList[2].Points) + Points.addPoints(shuffledList[3].Points);

            Deck shuffledDeck = new Deck(shuffledList);
            
            Console.WriteLine($"You have been dealt: {GetCardDercription(shuffledDeck.Next())}, {GetCardDercription(shuffledDeck.Next())}");
            // I want to store House invisible cards to show them to user at the end of the game
            var firstHouseCard = shuffledDeck.Next();
            var secondHouseCard = shuffledDeck.Next();
            houseCards.Add(firstHouseCard.Description);
            houseCards.Add(secondHouseCard.Description);
            Console.WriteLine($"House has been dealt: {GetCardDercription(firstHouseCard)}, {GetCardDercriptionInvisible(secondHouseCard)}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("Choose [1] to take another card");
            Console.WriteLine("Choose [2] to finish");
            Console.WriteLine();

            // Dialog with player
            bool correct = false;

            while (!correct)
            {
                string option = Console.ReadLine();
                Console.WriteLine("I choose: " + option);
                Console.WriteLine();
                
                if (option == "1")
                {
                    // Displays user card, get points as int from Card and add them to total
                    var betsUp = shuffledDeck.Next();
                    Console.WriteLine($"You have been dealt: {GetCardDercription(betsUp)}");
                      // When cards will run out then automatcally be shown players points and who win
                    if (GetCardDercription(betsUp) == "No more cards!")
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
                        break;
                    }
                    var addPoints = Points.addPoints(betsUp.Points);
                    totalMe = totalMe + addPoints;
                    // Displays house card(invisible), store house card to display them at the end of the game, gets Card points as int and add them to total
                    var housePoints = shuffledDeck.Next();
                    Console.WriteLine($"House has been dealt: {GetCardDercriptionInvisible(housePoints)}");
                    houseCards.Add(housePoints.Description);
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
                    // When user choose "2" (or something else except "1") it displays players points and who won the game
                    correct = true;
                    Console.WriteLine("You have " + totalMe + " points vs house have " + totalHouse + " points");
                    Console.Write("House cards were: " );
                    houseCards.ForEach(i => Console.Write("{0}\t", i));
                    Console.WriteLine();
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
        // I can choose method to make card visible or another method to make it invisibe
        public static string GetCardDercription(Card card)
        {
            if(card == null)
            {
                return "The cards are out!";
            }
            else {
                return card.Description;
            }
            
        }
        public static string GetCardDercriptionInvisible(Card card)
        {

            return card.Hidden ? "[?]" : card.Description;

        }

    }
}