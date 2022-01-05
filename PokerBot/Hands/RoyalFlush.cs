using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Royal flush object
    /// </summary>
    class RoyalFlush: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.RoyalFlush;
    }
}