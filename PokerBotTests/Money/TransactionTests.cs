using NUnit.Framework;
using PokerBot.Enums;
using PokerBot.Tests;

namespace PokerBot.Money.Tests
{
    [TestFixture()]
    public class TransactionTests
    {
        private const TransactionType GIVE = TransactionType.Give;
        private const TransactionType TAKE = TransactionType.Take;
        private const long VALUE = 2000;

        private Transaction GiveTransaction { get; set; }

        private Transaction TakeTransaction { get; set; }

        [SetUp]
        public void SetUp()
        {
            GiveTransaction = new Transaction(GIVE, VALUE);
            TakeTransaction = new Transaction(TAKE, VALUE);
        }

        [Test()]
        public void TransactionTest()
        {
            Assert.AreEqual(GIVE, GiveTransaction.Type);
            Assert.AreEqual(VALUE, GiveTransaction.Value);
        }

        [TestCaseSource(typeof(TransactionData), nameof(TransactionData.EqualsData))]
        public bool EqualsTest(Transaction x, Transaction y)
        {
            return x.Equals(y);
        }

        [Test()]
        public void ToStringTest()
        {
            Assert.AreEqual("+2000", GiveTransaction.ToString());
            Assert.AreEqual("-2000", TakeTransaction.ToString());
        }
    }
}