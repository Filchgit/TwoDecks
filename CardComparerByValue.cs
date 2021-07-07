using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit > y.Suit) return 1;
            else if (x.Suit < y.Suit) return -1;
            else                                  // now I just need to do the value bit, actually only reach this if suits are equal but this makes it easier to see what is going on
            {
                if ((int)x.Value < (int)y.Value) return 1;
                if ((int)x.Value > (int)y.Value) return -1;
                else return 0;
            }                            
        }
    }
}
