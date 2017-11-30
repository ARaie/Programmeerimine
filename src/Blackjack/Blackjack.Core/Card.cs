
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    using System;

    public class Card
    {
        public string displayRanks(Rank _rank)
        {
            if(_rank == Rank.two)
            {
                return "2";
            }
            if (_rank == Rank.three)
            {
                return "3";
            }
            if (_rank == Rank.four)
            {
                return "4";
            }
            if (_rank == Rank.five)
            {
                return "5";
            }
            if (_rank == Rank.six)
            {
                return "6";
            }
            if (_rank == Rank.seven)
            {
                return "7";
            }
            if (_rank == Rank.eight)
            {
                return "8";
            }
            if (_rank == Rank.nine)
            {
                return "9";
            }
            if (_rank == Rank.ten)
            {
                return "10";
            }
            if (_rank == Rank.jack)
            {
                return "J" ;
            }
            if (_rank == Rank.queen)
            {
                return "Q";
            }
            if (_rank == Rank.king)
            {
                return "K";
            }
           
            else
            {
                return "A";
            }

        }

        public string Description => displayRanks(_rank).ToString() + _suite.GetShortSuitesName().ToString();

        public int Points => _points;

        public bool Hidden { get; set; }

        private readonly Rank _rank;

        private readonly Suite _suite;

        private readonly int _points;

        public Card(Rank rank, Suite suite, int points, bool hidden = true)
        {
            _rank = rank;
            _suite = suite;
            _points = points;

            this.Hidden = hidden;
        }


    }
   
}
