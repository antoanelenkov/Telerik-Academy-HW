using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var lastCardIndex = this.Cards.Count - 1;
            for (int i = 0; i < this.Cards.Count; i++)
            {
                if (i == lastCardIndex)
                {
                    sb.Append(this.Cards[i].ToString());
                    break;
                }
                else
                {
                    sb.Append(this.Cards[i].ToString() + " & ");
                }
            }

            return sb.ToString();
        }
    }
}
