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
        public Ranking RankingTest(Tuple<Card, Card> player, Table table)
        {
            return new Hand(player, table).Ranking;
        }
    }
}