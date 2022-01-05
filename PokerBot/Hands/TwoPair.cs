using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Two pair object
    /// </summary>
    class TwoPair: IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        public Strength Strength => Strength.TwoPair;
    }
}