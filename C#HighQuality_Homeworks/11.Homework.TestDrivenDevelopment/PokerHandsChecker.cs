using System;
using System.Diagnostics;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("null value passed for hand");
            }
            else if (hand.Cards.Count != 5)
            {
                return false;
            }
            else
            {
                // Checks for equal cards
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int j = 0; j < hand.Cards.Count; j++)
                    {
                        if (i != j)
                        {
                            if (hand.Cards[i].Equals(hand.Cards[j]))
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("invalid hand");
            }

            var counter = 0;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        counter++;
                    }
                }
                if (counter == 4)
                {
                    return true;
                }
                counter = 0;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("invalid hand");
            }

            var initialFace = hand.Cards[0].Suit;
            foreach (var card in hand.Cards)
            {
                if (card.Suit != initialFace)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
