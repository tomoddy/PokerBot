using NUnit.Framework;
using PokerBot.Enums;

namespace PokerBot.Money.Tests
{
    [TestFixture()]
    public class WalletTests
    {
        private const long STACK = 1000;
        private const long VALUE = 500;

        private Wallet Wallet { get; set; }

        [SetUp]
        public void SetUp()
        {
            Wallet = new Wallet(STACK);
        }

        [Test()]
        public void WalletTest()
        {
            Assert.AreEqual(STACK, Wallet.Stack);
            Assert.AreEqual(1, Wallet.TransactionCount);
            Assert.IsTrue(new Transaction(TransactionType.Give, STACK).Equals(Wallet.GetTransaction(0)));
        }

        [Test()]
        public void GiveTest()
        {
            long stack = Wallet.Stack;
            Assert.AreEqual(1, Wallet.TransactionCount);
            Wallet.Give(VALUE);

            Assert.AreEqual(2, Wallet.TransactionCount);
            Assert.IsTrue(new Transaction(TransactionType.Give, VALUE).Equals(Wallet.GetTransaction(1)));
            Assert.AreEqual(stack + VALUE, Wallet.Stack);
        }

        [Test()]
        public void TakeTest()
        {
            long stack = Wallet.Stack;
            Assert.AreEqual(1, Wallet.TransactionCount);
            Wallet.Take(VALUE);

            Assert.AreEqual(2, Wallet.TransactionCount);
            Assert.IsTrue(new Transaction(TransactionType.Take, VALUE).Equals(Wallet.GetTransaction(1)));
            Assert.AreEqual(stack - VALUE, Wallet.Stack);
        }
    }
}