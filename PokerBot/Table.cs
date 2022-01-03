using PokerBot.Enums;
using System;
using System.Collections.Generic;

namespace PokerBot
{
    /// <summary>
    /// Table object
    /// </summary>
    public class Table
    {
        /// <summary>
        /// First flop card
        /// </summary>
        private Card Flop1 { get; set; }

        /// <summary>
        /// Second flop card
        /// </summary>
        private Card Flop2 { get; set; }

        /// <summary>
        /// Third flop card
        /// </summary>
        private Card Flop3 { get; set; }

        /// <summary>
        /// Turn card
        /// </summary>
        public Card Turn { get; private set; }

        /// <summary>
        /// River card
        /// </summary>
        public Card River { get; private set; }

        /// <summary>
        /// Flop cards
        /// </summary>
        public List<Card> Flop
        {
            get
            {
                if (Flop1 != null && Flop2 != null && Flop3 != null)
                    return new List<Card> { Flop1, Flop2, Flop3 };
                else
                    return new List<Card>();
            }
        }

        /// <summary>
        /// All cards on table
        /// </summary>
        public List<Card> Cards
        {
            get
            {
                if (Turn == null)
                    return new List<Card>(Flop);
                else   
                {
                    if (River == null)
                        return new List<Card>(Flop) { Turn };
                    else
                        return new List<Card>(Flop) { Turn, River };
                }
            }
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Object as string</returns>
        public override string ToString()
        {
            List<Card> retVal = new List<Card>(Cards);
            retVal.RemoveAll(card => card == null);
            return $"({string.Join(", ", retVal)})";
        }

        /// <summary>
        /// Add flop cards
        /// </summary>
        /// <param name="suit1">Suit of first card</param>
        /// <param name="rank1">Rank of first card</param>
        /// <param name="suit2">Suit of second card</param>
        /// <param name="rank2">Rank of second card</param>
        /// <param name="suit3">Suit of third card</param>
        /// <param name="rank3">Rank of third card</param>
        public void AddFlop(Suit suit1, Rank rank1, Suit suit2, Rank rank2, Suit suit3, Rank rank3)
        {
            if (Flop1 == null && Flop2 == null && Flop3 == null && Turn == null && River == null)
            {
                Flop1 = new Card(suit1, rank1, Position.Flop);
                Flop2 = new Card(suit2, rank2, Position.Flop);
                Flop3 = new Card(suit3, rank3, Position.Flop);
            }
            else
                throw new Exception("Invalid state");
        }

        /// <summary>
        /// Add turn card
        /// </summary>
        /// <param name="suit">Suit of card</param>
        /// <param name="rank">Rank of card</param>
        public void AddTurn(Suit suit, Rank rank)
        {
            if (Flop1 != null && Flop2 != null && Flop3 != null && Turn == null && River == null)
                Turn = new Card(suit, rank, Position.Turn);
            else
                throw new Exception("Invalid state");
        }

        /// <summary>
        /// Add river card
        /// </summary>
        /// <param name="suit">Suit of card</param>
        /// <param name="rank">Rank of card</param>
        public void AddRiver(Suit suit, Rank rank)
        {
            if (Flop1 != null && Flop2 != null && Flop3 != null && Turn != null && River == null)
                River = new Card(suit, rank, Position.River);
            else
                throw new Exception("Invalid state");
        }
    }
}