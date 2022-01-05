using NUnit.Framework;
using System.Collections.Generic;

namespace PokerBot.Tests
{
    [TestFixture]
    public class HelperTests
    {
        [Test]
        public void FormatListTest()
        {
            List<string> values = new() { "one", "two", "three" };
            Assert.AreEqual("(one, two, three)", Helper.FormatList(values));
        }
    }
}