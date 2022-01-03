using PokerBot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerBot
{
    public class Hand
    {
        // Constants
        private const int HAND_VARIATIONS = 7 - 4;
        private const int SUIT_VARIATIONS = 13 - 5;
        private const int SEQUENCE = 5;
        private const int FOAK = 4;
        private const int SET = 3;
        private const int PAIR = 2;

        /// <summary>
        /// Cards in hand and on table
        /// </summary>
        private List<Card> Cards { get; set; }

        /// <summary>
        /// Ranks of card
        /// </summary>
        private List<Rank> Ranks { get; set; }

        /// <summary>
        /// Suits of cards
        /// </summary>
        private List<Suit> Suits { get; set; }

        /// <summary>
        /// Royal flush
        /// </summary>
        private bool RoyalFlush
        {
            get
            {
                bool retVal = false;
                if (Cards.Count < SEQUENCE)
                    return retVal;

                foreach (Suit suit in Suits)
                {
                    if (Contains(suit, Rank.Ace) && Contains(suit, Rank.King) && Contains(suit, Rank.Queen) && Contains(suit, Rank.Jack) && Contains(suit, Rank.Ten))
                        retVal = true;
                }
                return retVal;
            }
        }

        /// <summary>
        /// Straight flush
        /// </summary>
        private bool StraightFlush
        {
            get
            {
                if (Cards.Count < SEQUENCE)
                    return false;

                foreach (Suit suit in Suits)
                {
                    for (int i = 0; i < HAND_VARIATIONS; i++)
                    {
                        for (int j = 0; j < SUIT_VARIATIONS; j++)
                        {
                            if (Compare(Cards.GetRange(i, 5), GenerateStraightFlush(j, suit)))
                                return true;
                        }
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Four of a kind
        /// </summary>
        private bool FourOfAKind
        {
            get
            {
                if (Cards.Count < FOAK)
                    return false;

                foreach (Rank rank in Ranks)
                {
                    if (Ranks.Where(r => r == rank).ToList().Count == FOAK)
                        return true;
                }
                return false;
            }
        }
        
        /// <summary>
        /// Full house
        /// </summary>
        private bool FullHouse
        {
            get
            {
                if (Cards.Count < SET + PAIR)
                    return false;

                Rank threeRank = 0;
                List<Rank> ranks = new List<Rank>(Ranks);

                foreach (Rank rank in ranks)
                {
                    if (Ranks.Where(r => r == rank).ToList().Count == SET)
                    {
                        threeRank = rank;
                        ranks.Remove(rank);
                        break;
                    }
                }

                if (threeRank == 0)
                    return false;
                else
                {
                    foreach (Rank rank in ranks)
                    {
                        if (Ranks.Where(r => r == rank).ToList().Count == PAIR)
                            return true;
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// Flush
        /// </summary>
        private bool Flush
        {
            get
            {
                if (Cards.Count < SEQUENCE)
                    return false;

                foreach (Suit suit in Suits)
                {
                    if (Cards.Where(card => card.Suit == suit).ToList().Count >= SEQUENCE)
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Straight
        /// </summary>
        private bool Straight
        {
            get
            {
                if (Cards.Count < SEQUENCE)
                    return false;

                for (int i = 0; i < HAND_VARIATIONS; i++)
                {
                    for (int j = 0; j < SUIT_VARIATIONS; j++)
                    {
                        if (Ranks.GetRange(i, 5).SequenceEqual(GenerateStraight(j)))
                            return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Three of a kind
        /// </summary>
        private bool ThreeOfAKind
        {
            get
            {
                if (Cards.Count < SET)
                    return false;

                foreach (Rank rank in Ranks)
                {
                    if (Ranks.Where(r => r == rank).ToList().Count == SET)
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Two pair
        /// </summary>
        private bool TwoPair
        {
            get
            {
                if (Cards.Count < 2 * PAIR)
                    return false;

                Rank pairRank = 0;
                List<Rank> ranks = new List<Rank>(Ranks);

                foreach (Rank rank in ranks)
                {
                    if (Ranks.Where(r => r == rank).ToList().Count == PAIR)
                    {
                        pairRank = rank;
                        ranks.RemoveAll(r => r == rank);
                        break;
                    }
                }

                if (pairRank == 0)
                    return false;
                else
                {
                    foreach (Rank rank in ranks)
                    {
                        if (Ranks.Where(r => r == rank).ToList().Count == PAIR)
                            return true;
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// Pair
        /// </summary>
        private bool Pair
        {
            get
            {
                if (Cards.Count < PAIR)
                    return false;

                foreach (Rank rank in Ranks)
                {
                    if (Ranks.Where(r => r == rank).ToList().Count == PAIR)
                        return true;
                }
                return false;
            }
        }

        public Ranking Ranking
        {
            get
            {
                if (RoyalFlush)
                    return Ranking.RoyalFlush;
                else if (StraightFlush)
                    return Ranking.StraightFlush;
                else if (FourOfAKind)
                    return Ranking.FourOfAKind;
                else if (FullHouse)
                    return Ranking.FullHouse;
                else if (Flush)
                    return Ranking.Flush;
                else if (Straight)
                    return Ranking.Straight;
                else if (ThreeOfAKind)
                    return Ranking.ThreeOfAKind;
                else if (TwoPair)
                    return Ranking.TwoPair;
                else if (Pair)
                    return Ranking.Pair;
                else
                    return Ranking.HighCard;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="player">Cards from player</param>
        /// <param name="table">Cards from table</param>
        public Hand(Tuple<Card, Card> player, Table table)
        {
            Cards = new List<Card>
            {
                player.Item1,
                player.Item2
            };
            Cards.AddRange(table.Cards);
            Cards = Cards.OrderBy(card => card.Rank).ThenBy(card => card.Suit).ToList();
            Ranks = Cards.OrderBy(card => card.Rank).Select(card => card.Rank).ToList();
            Suits = Cards.OrderBy(card => card.Suit).Select(card => card.Suit).ToList();
        }

        /// <summary>
        /// Check if hand contains card
        /// </summary>
        /// <param name="suit">Suit of card</param>
        /// <param name="rank">Rank of card</param>
        /// <returns></returns>
        private bool Contains(Suit suit, Rank rank)
        {
            return Cards.Where(c => c.Rank == rank && c.Suit == suit).ToList().Any();
        }

        /// <summary>
        /// Compare lists of cards
        /// </summary>
        /// <param name="x">First list</param>
        /// <param name="y">Second list</param>
        /// <returns>True if equal, false otherwise</returns>
        private bool Compare(List<Card> x, List<Card> y)
        {
            return Enumerable.SequenceEqual(x, y, new CardsComparer());
        }

        /// <summary>
        /// Generate example straight
        /// </summary>
        /// <param name="j">Start card value</param>
        /// <returns>List of ranks</returns>
        private List<Rank> GenerateStraight(int j)
        {
            List<Rank> retVal = new List<Rank>();
            for (int i = j + 2; i <= j + 6; i++)
                retVal.Add((Rank)i);
            return retVal;
        }

        /// <summary>
        /// Generate example straight flush
        /// </summary>
        /// <param name="j">Start card value</param>
        /// <param name="suit">Flush suit</param>
        /// <returns>List of cards</returns>
        private List<Card> GenerateStraightFlush(int j, Suit suit)
        {
            List<Card> retVal = new List<Card>();
            for (int i = j + 2; i <= j + 6; i++)
                retVal.Add(new Card(suit, (Rank)i, Position.Null));
            return retVal;
        }
    }
}