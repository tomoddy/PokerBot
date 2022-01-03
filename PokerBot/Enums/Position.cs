using System;
using System.Linq;

namespace PokerBot.Enums
{
    /// <summary>
    /// Position enum
    /// </summary>
    public enum Position
    {
        Null = 0,
        Deck = 1,
        Hand = 2,
        Flop = 3,
        Turn = 4,
        River = 5
    }

    /// <summary>
    /// Position extenstion methods
    /// </summary>
    public static class PositionMethods
    {
        // Random object
        private static readonly Random Rand = new Random();

        /// <summary>
        /// Create random position
        /// </summary>
        /// <returns>Random position</returns>
        public static Position Random()
        {
            return (Position)Rand.Next(Enum.GetValues(typeof(Position)).Cast<int>().Min(), Enum.GetValues(typeof(Position)).Cast<int>().Max() + 1);
        }
    }
}