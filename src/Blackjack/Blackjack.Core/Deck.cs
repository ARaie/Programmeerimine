using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Deck
    {

        private readonly List<Card> _cards;

        // Gives back right list according to user choice
        public static List<Card> List(string userInput)
        {
            if (userInput == "52")
            {
                return D52.Shuffle();
            }
            else
            {
                return D36.Shuffle();
            }
        }

        public Deck(List<Card> cards)
        {
            _cards = cards;
        }
        // Populates list with cards
        public static List<Card> d52()
        {
            var result = new List<Card>();

         
            for (var suit = Suite.Club; suit <= Suite.Diamond; suit++)
            {
                for (var rank = Rank.two; rank <= Rank.ace; rank++)
                {
                    var card = new Card(rank, suit, (int) rank, true);
                    result.Add(card);
                }
            }

            return result;
        }
        // Populates list with cards
        public static List<Card> d36()
        {
            var result = new List<Card>();


            for (var suit = Suite.Club; suit <= Suite.Diamond; suit++)
            {
                for (var rank = Rank.six; rank <= Rank.ace; rank++)
                {
                    var card = new Card(rank, suit, (int)rank, true);
                    result.Add(card);
                }
            }

            return result;
        }
        //Makes Deck from populated list
        public static Deck D36 = new Deck(d36());

        //Makes Deck from populated list
        public static Deck D52 = new Deck(d52());


        public List<Card> Shuffle()
        {
            // Insert cards at random order into the shuffled list
            var shuffled = new List<Card>();
            var random = new Random();

            // As long as there are any cards left to insert randomly
            while (_cards.Count != 0)
            {
                // Get the index of the random card to insert
                var i = random.Next(_cards.Count);

                // Insert it
                shuffled.Add(_cards[i]);

                // Remove from non-shuffled list
                _cards.RemoveAt(i);
            }
            return shuffled;
        }
        // Method for get next card from deck
        public Card Next()
        {
            Card card = null;

            for( int i = 0; i < _cards.Count; i++)
            {
              
                card = _cards[i];
                _cards.RemoveAt(i);
                i++;
                return card;
            }

            return card;
        }


    }
}

