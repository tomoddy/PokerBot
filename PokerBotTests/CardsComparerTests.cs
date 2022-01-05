using NUnit.Framework;

namespace PokerBot.Tests
{
    [TestFixture()]
    public class CardsComparerTests
    {
        [TestCaseSource(typeof(CardData), nameof(CardData.EqualsData))]
        public bool EqualsTest(Card x, Card y)
        {
            return new CardsComparer().Equals(x, y);
        }

        [TestCaseSource(typeof(CardData), nameof(CardData.EqualsWithPositionData))]
        public bool EqualsWithPositionTest(Card x, Card y)
        {
            return CardsComparer.EqualsWithPosition(x, y);
        }
    }
}