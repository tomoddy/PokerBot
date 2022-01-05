using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Four of a kind object
    /// </summary>
    class FourOfAKind : IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.FourOfAKind;
    }
}