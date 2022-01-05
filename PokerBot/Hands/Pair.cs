using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Pair object
    /// </summary>
    class Pair : IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.Pair;
    }
}