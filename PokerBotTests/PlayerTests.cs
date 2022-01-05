using NUnit.Framework;
using PokerBot.Enums;
using System;

namespace PokerBot.Tests
{
    [TestFixture()]
    public class PlayerTests
    {
        private const int ID = 1;
        private const string NAME = "Test Name";
        private const long STACK = 2000;

        private Player Player { get; set; }

        private Card X { get; set; }

        private Card Y { get; set; }

        private Card Z { get; set; }

        [SetUp]
        public void SetUp()
        {
            Player = new Player(ID, NAME, STACK);
            X = new Card(Suit.Clubs, Rank.Ace, Position.Null);
            Y = new Card(Suit.Diamonds, Rank.Eight, Position.Null);
            Y = new Card(Suit.Hearts, Rank.Four, Position.Null);
        }

        [Test()]
        public void PlayerTest()
        {
            Assert.AreEqual(ID, Player.Id);
            Assert.AreEqual(NAME, Player.Name);
            Assert.AreEqual(STACK, Player.Wallet.Stack);
            Assert.IsNull(Player.GetCards());
        }

        [Test()]
        public void GiveCardTest()
        {
            Assert.IsNull(Player.GetCards());
            Player.GiveCard(X);

            Assert.IsTrue(Player.GetCards().Item1.Equals(X));
            Assert.IsNull(Player.GetCards().Item2);

            Player.GiveCard(Y);
            Assert.IsTrue(Player.GetCards().Item1.Equals(X));
            Assert.IsTrue(Player.GetCards().Item2.Equals(Y));

            Assert.Throws<Exception>(() => Player.GiveCard(Z));
        }

        [Test()]
        public void ClearCardsTest()
        {
            Player.GiveCard(X);
            Player.GiveCard(Y);

            Tuple<Card, Card> hand = Player.ClearCards();
            Assert.IsTrue(hand.Item1.Equals(X));
            Assert.IsTrue(hand.Item2.Equals(Y));

            Assert.IsNull(Player.GetCards());
        }

        [Test()]
        public void GetCardsTest()
        {
            Player.GiveCard(X);
            Player.GiveCard(Y);

            Tuple<Card, Card> hand = Player.GetCards();
            Assert.IsTrue(hand.Item1.Equals(X));
            Assert.IsTrue(hand.Item2.Equals(Y));
        }

        [Test()]
        [Ignore("Incomplete")]
        public void GetHandTest()
        {
            
        }
    }
}