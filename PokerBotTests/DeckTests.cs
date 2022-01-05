using PokerBot;
using NUnit.Framework;
using PokerBot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerBot.Tests
{
    [TestFixture()]
    public class DeckTests
    {
        private Deck Deck { get; set; }

        [SetUp]
        public void SetUp()
        {
            Deck = new Deck();
        }

        [Test()]
        public void ShuffleTest()
        {
            Deck copy = new(Deck);
            Deck.Shuffle();
            Assert.False(Deck.Draw().Equals(copy.Draw()));
        }

        [Test()]
        public void DrawTest()
        {
            for (int i = 0; i < Deck.DECK_SIZE; i++)
                Assert.IsNotNull(Deck.Draw());

            Assert.IsNull(Deck.Draw());
        }

        [Test()]
        public void DiscardTest()
        {
            for (int i = 0; i < Deck.DECK_SIZE; i++)
                Deck.Discard();

            Assert.IsNull(Deck.Draw());
        }

        [Test()]
        public void ToStringTest()
        {
            List<Card> deck = new();
            for (int i = 0; i < Deck.DECK_SIZE; i++)
                deck.Add(Deck.Draw());

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    Assert.AreEqual(1, deck.Where(card => card.Suit == suit && card.Rank == rank).ToList().Count);
        }
    }
}