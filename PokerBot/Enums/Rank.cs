﻿using System;

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
            switch (rank)
            {
                case Rank.Ace:
                    return "A";
                case Rank.Two:
                    return "2";
                case Rank.Three:
                    return "3";
                case Rank.Four:
                    return "4";
                case Rank.Five:
                    return "5";
                case Rank.Six:
                    return "6";
                case Rank.Seven:
                    return "7";
                case Rank.Eight:
                    return "8";
                case Rank.Nine:
                    return "9";
                case Rank.Ten:
                    return "10";
                case Rank.Jack:
                    return "J";
                case Rank.Queen:
                    return "Q";
                case Rank.King:
                    return "K";
                default:
                    throw new Exception($"Invalid rank \"{rank}\"");
            }
        }
    }
}