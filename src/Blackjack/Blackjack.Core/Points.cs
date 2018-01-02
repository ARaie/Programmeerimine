using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Points
    {
        // It takes int from Rank enum and return right int of points. In Enum I had to count cards, but here I give right value points to cards(king, queen and jack have value 10)
        public static int addPoints (int cardPoints)
        {
            if (cardPoints == 2)
            {
                return 2;
            }
            if (cardPoints == 3)
            {
                return 3;
            }
            if (cardPoints == 4)
            {
                return 4;
            }
            if (cardPoints == 5)
            {
                return 5;
            }
            if (cardPoints == 6)
            {
                return 6;
            }
            if (cardPoints == 7)
            {
                return 7;
            }
            if (cardPoints == 8)
            {
                return 8;
            }
            if (cardPoints == 9)
            {
                return 9;
            }
            if (cardPoints == 10)
            {
                return 10;
            }
            if (cardPoints == 11)
            {
                return 10;
            }
            if (cardPoints == 12)
            {
                return 10;
            }
            if (cardPoints == 13)
            {
                return 10;
            }
            else
            {
                return 11;
            }
        }
    }
}
