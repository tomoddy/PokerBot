using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Straight object
    /// </summary>
    class Straight: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.Straight;
    }
}