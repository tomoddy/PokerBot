using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Full house object
    /// </summary>
    class FullHouse: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.FullHouse;
    }
}