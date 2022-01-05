using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Three of a kind object
    /// </summary>
    class ThreeOfAKind: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.ThreeOfAKind;
    }
}