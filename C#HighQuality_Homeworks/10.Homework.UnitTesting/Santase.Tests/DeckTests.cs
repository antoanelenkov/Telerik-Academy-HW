using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Santase.Logic.Cards;
using Santase.Logic;
using System.Diagnostics;

namespace Santase.Tests
{
    [TestClass]
    public class DeckTests
    {
        private Deck testDeck;

        [TestInitialize]
        public void InitilizeComponents()
        {
            this.testDeck = new Deck();
        }

        [TestMethod]
        [ExpectedException(typeof(InternalGameException))]
        public void GetNextCard_WhenEmptyDeck_ShouldThrow()
        {
            while (testDeck.CardsLeft >= 0)
            {
                Trace.WriteLine(testDeck.CardsLeft);
                testDeck.GetNextCard();
            }
        }

        [TestMethod]
        public void GetNextCard_WhenIsFullDeck_ShouldHas23()
        {
            testDeck.GetNextCard();
     
            Assert.AreEqual(23, testDeck.CardsLeft);
        }

        [TestMethod]
        public void GetTrumpCard()
        {
            Assert.IsNotNull(testDeck.GetTrumpCard);
        }

        [TestMethod]
        public void ChangeTrumpCard()
        {
            var card = testDeck.GetNextCard();
            testDeck.ChangeTrumpCard(card);

            Assert.AreEqual(card, testDeck.GetTrumpCard);
        }
    }
}
