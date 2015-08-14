namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardToString()
        {
            Card testCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card testCard2 = new Card(CardFace.Eight, CardSuit.Diamonds);

            Assert.AreEqual("Ace Clubs", testCard.ToString());
            Assert.AreEqual("Eight Diamonds", testCard2.ToString());
        }
    }
}
