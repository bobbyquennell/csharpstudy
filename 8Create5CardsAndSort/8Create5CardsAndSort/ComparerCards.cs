using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Create5CardsAndSort
{
    enum SortCriteria {
        SuitsOnly,
        ValueOnly,
        SuitsThenValue,
        ValueThenSuits,
    }
    class ComparerCards: IComparer<Card>
    {
        public SortCriteria SortMethod = SortCriteria.ValueOnly;
            //{ get; set; }
        public int Compare(Card A, Card B)
        {
            if (SortMethod == SortCriteria.SuitsOnly)
            {
                if ((int)A.Suit > (int)B.Suit)
                {
                    return 1;

                }
                else if ((int)A.Suit == (int)B.Suit)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }

            }
            else if (SortMethod == SortCriteria.ValueOnly)
            {
                if ((int)A.Value > (int)B.Value)
                {
                    return 1;

                }
                else if ((int)A.Value == (int)B.Value)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
                
            }
            else if (SortMethod == SortCriteria.SuitsThenValue)
            {
                if ((int)A.Suit > (int)B.Suit)
                {
                    return 1;

                }
                else if ((int)A.Suit == (int)B.Suit)
                {
                    if ((int)A.Value > (int)B.Value)
                    {
                        return 1;

                    }
                    else if ((int)A.Value == (int)B.Value)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
                
            }
            else
            {
                if ((int)A.Value > (int)B.Value)
                {
                    return 1;

                }
                else if ((int)A.Value == (int)B.Value)
                {
                    if ((int)A.Suit > (int)B.Suit)
                    {
                        return 1;

                    }
                    else if ((int)A.Suit == (int)B.Suit)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }

            }

        }


    }
}
