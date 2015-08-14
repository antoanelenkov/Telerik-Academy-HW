namespace Poker.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void HandToString()
        {
            Card testCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card testCard2 = new Card(CardFace.Eight, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(testCard);
            cards.Add(testCard2);

            Hand testHand = new Hand(cards);

            Assert.AreEqual("Ace Clubs & Eight Diamonds", testHand.ToString());
        }
    }
}

