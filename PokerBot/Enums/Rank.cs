using System;

namespace PokerBot.Enums
{
    /// <summary>
    /// Rank enum
    /// </summary>
    public enum Rank
    {
        Ace = 14,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    /// <summary>
    /// Rank extension methods
    /// </summary>
    static class RankMethods
    {
        /// <summary>
        /// Generate string symbol from enum
        /// </summary>
        /// <param name="rank">Card rank</param>
        /// <returns>String symbol</returns>
        public static string Symbol(this Rank rank)
        {
            return rank switch
            {
                Rank.Ace => "A",
                Rank.Two => "2",
                Rank.Three => "3",
                Rank.Four => "4",
                Rank.Five => "5",
                Rank.Six => "6",
                Rank.Seven => "7",
                Rank.Eight => "8",
                Rank.Nine => "9",
                Rank.Ten => "10",
                Rank.Jack => "J",
                Rank.Queen => "Q",
                Rank.King => "K",
                _ => throw new Exception($"Invalid rank \"{rank}\""),
            };
        }
    }
}