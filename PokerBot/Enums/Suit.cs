using System;

namespace PokerBot.Enums
{
    /// <summary>
    /// Suit enum
    /// </summary>
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    /// <summary>
    /// Suit extension methods
    /// </summary>
    static class SuitMethods
    {
        /// <summary>
        /// Generate string symbol from enum
        /// </summary>
        /// <param name="suit">Card suit</param>
        /// <returns>String symbol</returns>
        public static string Symbol(this Suit suit)
        {
            switch (suit)
            {
                case Suit.Clubs:
                    return "♣";
                case Suit.Diamonds:
                    return "♦";
                case Suit.Hearts:
                    return "♥";
                case Suit.Spades:
                    return "♠";
                default:
                    throw new Exception($"Invalid suit \"{suit}\"");
            }
        }
    }
}