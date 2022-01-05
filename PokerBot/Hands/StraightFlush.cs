using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Straight flush object
    /// </summary>
    class StraightFlush: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.StraightFlush;
    }
}