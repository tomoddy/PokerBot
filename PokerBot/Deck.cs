using PokerBot.Enums;
using System;
using System.Collections.Generic;

namespace PokerBot
{
    /// <summary>
    /// Deck object
    /// </summary>
    public class Deck
    {
        // Deck size
        public const int DECK_SIZE = 52;

        // Random object
        private static readonly Random Rand = new();

        /// <summary>
        /// Cards in deck
        /// </summary>
        private List<Card> Cards { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(suit, rank, Position.Deck));
                }
            }
            Shuffle();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="deck">Deck to copy</param>
        public Deck(Deck deck)
        {
            Cards = new List<Card>(deck.Cards);
        }

        /// <summary>
        /// Shuffle deck
        /// </summary>
        public void Shuffle()
        {
            int n = Cards.Count;
            while (n-- > 1)
            {
                int k = Rand.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }

        /// <summary>
        /// Draw card from top of deck
        /// </summary>
        /// <returns>Top card</returns>
        public Card Draw()
        {
            if (Cards.Count > 0)
            {
                Card temp = Cards[0];
                Cards.RemoveAt(0);
                return temp;
            }
            else
                return null;
        }

        /// <summary>
        /// Discard card from top of deck
        /// </summary>
        public void Discard()
        {
            Cards.RemoveAt(0);
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Object as string</returns>
        public override string ToString()
        {
            return Helper.FormatList(Cards);
        }
    }
}