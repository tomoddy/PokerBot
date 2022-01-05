using NUnit.Framework;
using PokerBot;
using System.Collections.Generic;

namespace PokerBotTests
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