using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Points
    {
        public static int addPoints (int card)
        {
            if (card == 2)
            {
                return 2;
            }
            if (card == 3)
            {
                return 3;
            }
            if (card == 4)
            {
                return 4;
            }
            if (card == 5)
            {
                return 5;
            }
            if (card == 6)
            {
                return 6;
            }
            if (card == 7)
            {
                return 7;
            }
            if (card == 8)
            {
                return 8;
            }
            if (card == 9)
            {
                return 9;
            }
            if (card == 10)
            {
                return 10;
            }
            if (card == 11)
            {
                return 10;
            }
            if (card == 12)
            {
                return 10;
            }
            if (card == 13)
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
