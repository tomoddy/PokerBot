using PokerBot;
using NUnit.Framework;
using PokerBot.Enums;
using System;

namespace PokerBot.Tests
{
    [TestFixture]
    public class HandTests
    {
        [TestCaseSource(typeof(HandData), nameof(HandData.RankingData))]
        public Strength RankingTest(Tuple<Card, Card> player, Table table)
        {
            Assert.Fail();
            return 0;
            //return new Hand(player, table).Ranking;
        }
    }
}