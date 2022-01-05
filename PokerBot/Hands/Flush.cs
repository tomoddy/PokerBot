using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Flush object
    /// </summary>
    class Flush : IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.Flush;
    }
}