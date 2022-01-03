using NUnit.Framework;

namespace PokerBot.Tests
{
    [TestFixture()]
    public class CardTests
    {
        [TestCaseSource(typeof(CardData), nameof(CardData.ToStringData))]
        public string RankingTest(Card card)
        {
            return card.ToString();
        }

        [TestCaseSource(typeof(CardData), nameof(CardData.EqualsData))]
        public bool EqualsTest(Card x, Card y)
        {
            return x.Equals(y);
        }

        [TestCaseSource(typeof(CardData), nameof(CardData.EqualsWithPositionData))]
        public bool EqualsWithPositionTest(Card x, Card y)
        {
            return x.EqualsWithPosition(y);
        }
    }
}