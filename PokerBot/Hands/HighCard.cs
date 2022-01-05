using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// High card object
    /// </summary>
    class HighCard : IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.HighCard;
    }
}