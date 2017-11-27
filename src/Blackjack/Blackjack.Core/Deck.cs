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

        public Deck(List<Card> cards)
        {
            _cards = cards;
        }
        // public static Deck D36 = new Deck();

        // public static Deck D52 = new Deck();

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

        public Card Next()
        {
            Card card = _cards.ElementAt(0);
            _cards.RemoveAt(0);

            return card;
        }


    }
}

