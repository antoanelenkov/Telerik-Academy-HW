namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        private IPokerHandsChecker checker;
        private Hand validHand;
        private Hand invalidNumberOfCardsHand;
        private Hand duplicatedCardsHand;
        private Hand flushHand;
        private Hand invalidFlushHand;
        private Hand fourOfAKindInARowHand;
        private Hand fourOfAKindNotInARowHand;
        private Hand invalidFourOfAKindHand;



        [TestInitialize]
        public void ComponentsInitialize()
        {
            checker = new PokerHandsChecker();

            Card testCard1 = new Card(CardFace.Ace, CardSuit.Clubs);
            Card testCard2 = new Card(CardFace.Eight, CardSuit.Diamonds);
            Card testCard3 = new Card(CardFace.Nine, CardSuit.Diamonds);
            Card testCard4 = new Card(CardFace.Seven, CardSuit.Hearts);
            Card testCard5 = new Card(CardFace.Ten, CardSuit.Spades);

            var validCards = new List<ICard>();
            validCards.Add(testCard1);
            validCards.Add(testCard2);
            validCards.Add(testCard3);
            validCards.Add(testCard4);
            validCards.Add(testCard5);
            validHand = new Hand(validCards);           

            var invalidNumberOfCards = new List<ICard>();
            invalidNumberOfCards.Add(testCard1);
            invalidNumberOfCards.Add(testCard2);
            invalidNumberOfCards.Add(testCard3);
            invalidNumberOfCards.Add(testCard4);
            invalidNumberOfCardsHand = new Hand(invalidNumberOfCards);


            var duplicatedCards = new List<ICard>();
            duplicatedCards.Add(testCard1);
            duplicatedCards.Add(testCard2);
            duplicatedCards.Add(testCard3);
            duplicatedCards.Add(testCard4);
            duplicatedCards.Add(testCard4);
            duplicatedCardsHand = new Hand(duplicatedCards);

            var flushCards = new List<ICard>();
            flushCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            flushCards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            flushCards.Add(new Card(CardFace.Four, CardSuit.Clubs));
            flushCards.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            flushCards.Add(new Card(CardFace.Seven, CardSuit.Clubs));
            flushHand = new Hand(flushCards);

            var invalidFlushCards = new List<ICard>();
            invalidFlushCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            invalidFlushCards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            invalidFlushCards.Add(new Card(CardFace.Four, CardSuit.Clubs));
            invalidFlushCards.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            invalidFlushCards.Add(new Card(CardFace.Seven, CardSuit.Clubs));
            invalidFlushHand = new Hand(invalidFlushCards);

            var fourOfAKindCardsInARowCollection = new List<ICard>();
            fourOfAKindCardsInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fourOfAKindCardsInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            fourOfAKindCardsInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fourOfAKindCardsInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Spades));
            fourOfAKindCardsInARowCollection.Add(new Card(CardFace.Eight, CardSuit.Clubs));
            fourOfAKindInARowHand = new Hand(fourOfAKindCardsInARowCollection);

            var fourOfAKindCardsNotInARowCollection = new List<ICard>();
            fourOfAKindCardsNotInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fourOfAKindCardsNotInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            fourOfAKindCardsNotInARowCollection.Add(new Card(CardFace.Eight, CardSuit.Clubs));
            fourOfAKindCardsNotInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fourOfAKindCardsNotInARowCollection.Add(new Card(CardFace.Ace, CardSuit.Spades));
            fourOfAKindNotInARowHand = new Hand(fourOfAKindCardsNotInARowCollection);

            var invalidFourOfAkindCardsCollection = new List<ICard>();
            invalidFourOfAkindCardsCollection.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            invalidFourOfAkindCardsCollection.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            invalidFourOfAkindCardsCollection.Add(new Card(CardFace.Five, CardSuit.Spades));
            invalidFourOfAkindCardsCollection.Add(new Card(CardFace.Five, CardSuit.Clubs));
            invalidFourOfAkindCardsCollection.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            invalidFourOfAKindHand = new Hand(invalidFourOfAkindCardsCollection);
        }
         
        [TestMethod]
        public void IsValidHand_WithFiveDifferentCards_ShouldBeTrue()
        {
            Assert.IsTrue(checker.IsValidHand(validHand));
        }

        [TestMethod]
        public void IsValidHand_WithFourCards_ShouldBeFalse()
        {
            Assert.IsFalse(checker.IsValidHand(invalidNumberOfCardsHand));
        }

        [TestMethod]
        public void IsValidHand_WithDuplicatedCards_ShouldBeFalse()
        {
            Assert.IsFalse(checker.IsValidHand(duplicatedCardsHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidHand_NullValuePassed_ShouldThrow()
        {
            Assert.IsFalse(checker.IsValidHand(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFlush_WithInvalidCards_ShouldThrow()
        {
            Assert.IsTrue(checker.IsFlush(invalidNumberOfCardsHand));
        }

        [TestMethod]
        public void IsFlush_WithFiveCardsFromOneCardSuit_ShouldBeTrue()
        {
            Assert.IsTrue(checker.IsFlush(flushHand));
        }

        [TestMethod]
        public void IsFourOFAKind_WithFourCardsInARowFromOneFace_ShouldBeTrue()
        {
            Assert.IsTrue(checker.IsFourOfAKind(fourOfAKindInARowHand));
        }

        [TestMethod]
        public void IsFourOFAKind_WithFourCardsNotInARowFromOneFace_ShouldBeTrue()
        {
            Assert.IsTrue(checker.IsFourOfAKind(fourOfAKindNotInARowHand));
        }

        [TestMethod]
        public void IsFlush_WithFiveCardsFromDifferentCardSuit_ShouldBeFalse()
        {
            Assert.IsTrue(checker.IsFlush(invalidFlushHand));
        }

        [TestMethod]
        public void IsFourOFAKind_WithoutFourCardsFromOneFace_ShouldBeFalse()
        {
            Assert.IsFalse(checker.IsFourOfAKind(invalidFourOfAKindHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFourOfAKind_WithInvalidCards_ShouldThrow()
        {
            Assert.IsTrue(checker.IsFourOfAKind(invalidNumberOfCardsHand));
        }
    }
}
