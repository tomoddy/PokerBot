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
            Assert.IsNull(Player.Hand);
        }

        [Test()]
        public void GiveTest()
        {
            Assert.IsNull(Player.Hand);
            Player.Give(X);

            Assert.IsTrue(Player.Hand.Item1.Equals(X));
            Assert.IsNull(Player.Hand.Item2);

            Player.Give(Y);
            Assert.IsTrue(Player.Hand.Item1.Equals(X));
            Assert.IsTrue(Player.Hand.Item2.Equals(Y));

            Assert.Throws<Exception>(() => Player.Give(Z));
        }

        [Test()]
        public void ClearTest()
        {
            Player.Give(X);
            Player.Give(Y);

            Tuple<Card, Card> hand = Player.Clear();
            Assert.IsTrue(hand.Item1.Equals(X));
            Assert.IsTrue(hand.Item2.Equals(Y));

            Assert.IsNull(Player.Hand);
        }
    }
}