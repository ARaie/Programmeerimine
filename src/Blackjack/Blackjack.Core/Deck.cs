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

        //public Shuffle()
        //{
           
        //}
        public Card  Next()
        {

            var card = _cards.ElementAt(0);
            _cards.RemoveAt(0);
            return card;
        }
        

    }
}
