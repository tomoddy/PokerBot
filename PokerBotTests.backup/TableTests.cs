using PokerBot;
using NUnit.Framework;
using PokerBot.Enums;
using System;

namespace PokerBot.Tests
{
    [TestFixture()]
    public class TableTests
    {
        private Table Table { get; set; }

        [SetUp]
        public void SetUp()
        {
            Table = new Table();
        }

        [Test()]
        public void ToStringTest()
        {
            Assert.AreEqual("()", Table.ToString());

            Table.AddFlop(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace, Suit.Hearts, Rank.Ace);
            Assert.AreEqual("(A♣, A♦, A♥)", Table.ToString());

            Table.AddTurn(Suit.Spades, Rank.Ace);
            Assert.AreEqual("(A♣, A♦, A♥, A♠)", Table.ToString());

            Table.AddRiver(Suit.Clubs, Rank.King);
            Assert.AreEqual("(A♣, A♦, A♥, A♠, K♣)", Table.ToString());
        }

        [Test()]
        public void AddFlopTest()
        {
            Assert.IsEmpty(Table.Cards);

            Assert.DoesNotThrow(() => Table.AddFlop(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace, Suit.Hearts, Rank.Ace));
            Assert.Throws<Exception>(() => Table.AddFlop(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace, Suit.Hearts, Rank.Ace));

            Assert.IsTrue(new Card(Suit.Clubs, Rank.Ace, Position.Null).Equals(Table.Flop[0]));
            Assert.IsTrue(new Card(Suit.Diamonds, Rank.Ace, Position.Null).Equals(Table.Flop[1]));
            Assert.IsTrue(new Card(Suit.Hearts, Rank.Ace, Position.Null).Equals(Table.Flop[2]));
        }

        [Test()]
        public void AddTurnTest()
        {
            Table.AddFlop(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace, Suit.Hearts, Rank.Ace);
            Assert.IsNull(Table.Turn);

            Assert.DoesNotThrow(() => Table.AddTurn(Suit.Spades, Rank.Ace));
            Assert.Throws<Exception>(() => Table.AddTurn(Suit.Clubs, Rank.King));

            Assert.IsTrue(new Card(Suit.Spades, Rank.Ace, Position.Null).Equals(Table.Turn));
            Assert.IsNull(Table.River);
        }

        [Test()]
        public void AddRiverTest()
        {
            Table.AddFlop(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace, Suit.Hearts, Rank.Ace);
            Table.AddTurn(Suit.Spades, Rank.Ace);
            Assert.IsNull(Table.River);

            Assert.DoesNotThrow(() => Table.AddRiver(Suit.Clubs, Rank.King));
            Assert.Throws<Exception>(() => Table.AddRiver(Suit.Clubs, Rank.King));

            Assert.IsTrue(new Card(Suit.Clubs, Rank.King, Position.Null).Equals(Table.River));
        }

        [Test()]
        [Ignore("")]
        public void AddFlopTest1()
        {
            Assert.Fail();
        }

        [Test()]
        [Ignore("")]
        public void AddTurnTest1()
        {
            Assert.Fail();
        }

        [Test()]
        [Ignore("")]
        public void AddRiverTest1()
        {
            Assert.Fail();
        }
    }
}