using NUnit.Framework;
using PokerBot.Enums;
using System;

namespace PokerBot.Tests
{
    [TestFixture]
    public class HandTests
    {
        [TestCaseSource(typeof(HandData), nameof(HandData.StrengthData))]
        public Strength StrengthTest(Tuple<Card, Card> player, Table table)
        {
            return new Hand(player, table).Ranking.Strength;
        }
    }
}