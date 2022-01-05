using System.Collections.Generic;

namespace PokerBot
{
    /// <summary>
    /// Card comparer extension
    /// </summary>
    public class CardsComparer : IEqualityComparer<Card>
    {
        /// <summary>
        /// Checks if cards are equal (ignoring position)
        /// </summary>
        /// <param name="x">First card</param>
        /// <param name="y">Second card</param>
        /// <returns>True if equal, false otherwise</returns>
        public bool Equals(Card x, Card y)
        {
            return x?.Rank == y?.Rank && x?.Suit == y?.Suit;
        }

        /// <summary>
        /// Checks if cards are equal (including position)
        /// </summary>
        /// <param name="x">First card</param>
        /// <param name="y">Second card</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool EqualsWithPosition(Card x, Card y)
        {
            return x.Rank == y.Rank && x.Suit == y.Suit && x.Position == y.Position;
        }

        /// <summary>
        /// Get hash code (base)
        /// </summary>
        /// <param name="obj">Card</param>
        /// <returns>Hash code</returns>
        public int GetHashCode(Card obj)
        {
            return base.GetHashCode();
        }
    }
}