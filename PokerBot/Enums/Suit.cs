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
            return suit switch
            {
                Suit.Clubs => "♣",
                Suit.Diamonds => "♦",
                Suit.Hearts => "♥",
                Suit.Spades => "♠",
                _ => throw new Exception($"Invalid suit \"{suit}\""),
            };
        }
    }
}