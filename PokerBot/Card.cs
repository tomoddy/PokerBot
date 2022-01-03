using PokerBot.Enums;

namespace PokerBot
{
    /// <summary>
    /// Card object
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Suit of card
        /// </summary>
        public Suit Suit { get; private set; }

        /// <summary>
        /// Rank of card
        /// </summary>
        public Rank Rank { get; private set; }

        /// <summary>
        /// Position of card
        /// </summary>
        public Position Position { get; private set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="suit">Suit</param>
        /// <param name="rank">Rank</param>
        /// <param name="position">Position</param>
        public Card(Suit suit, Rank rank, Position position)
        {
            Suit = suit;
            Rank = rank;
            Position = position;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Object as string</returns>
        public override string ToString()
        {
            return $"{Rank.Symbol()}{Suit.Symbol()}";
        }

        /// <summary>
        /// Checks if cards are equal (ignoring position)
        /// </summary>
        /// <param name="card">Card to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public bool Equals(Card card)
        {
            return Suit == card.Suit && Rank == card.Rank;
        }

        /// <summary>
        /// Checks if cards are equal (including position)
        /// </summary>
        /// <param name="card">Card to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public bool EqualsWithPosition(Card card)
        {
            return Suit == card.Suit && Rank == card.Rank && Position == card.Position;
        }
    }
}