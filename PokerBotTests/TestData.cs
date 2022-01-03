using NUnit.Framework;
using PokerBot.Enums;
using PokerBot.Money;
using System;
using System.Collections;

namespace PokerBot.Tests
{
    class CardData
    {
        public static IEnumerable ToStringData
        {
            get
            {
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Two, Position.Null)).Returns("2♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Three, Position.Null)).Returns("3♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Four, Position.Null)).Returns("4♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Five, Position.Null)).Returns("5♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Six, Position.Null)).Returns("6♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Seven, Position.Null)).Returns("7♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Eight, Position.Null)).Returns("8♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Nine, Position.Null)).Returns("9♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ten, Position.Null)).Returns("10♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Jack, Position.Null)).Returns("J♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Queen, Position.Null)).Returns("Q♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.King, Position.Null)).Returns("K♣");
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Null)).Returns("A♣");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Two, Position.Null)).Returns("2♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Three, Position.Null)).Returns("3♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Four, Position.Null)).Returns("4♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Five, Position.Null)).Returns("5♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Six, Position.Null)).Returns("6♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Seven, Position.Null)).Returns("7♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Eight, Position.Null)).Returns("8♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Nine, Position.Null)).Returns("9♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Ten, Position.Null)).Returns("10♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Jack, Position.Null)).Returns("J♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Queen, Position.Null)).Returns("Q♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.King, Position.Null)).Returns("K♦");
                yield return new TestCaseData(new Card(Suit.Diamonds, Rank.Ace, Position.Null)).Returns("A♦");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Two, Position.Null)).Returns("2♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Three, Position.Null)).Returns("3♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Four, Position.Null)).Returns("4♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Five, Position.Null)).Returns("5♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Six, Position.Null)).Returns("6♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Seven, Position.Null)).Returns("7♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Eight, Position.Null)).Returns("8♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Nine, Position.Null)).Returns("9♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Ten, Position.Null)).Returns("10♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Jack, Position.Null)).Returns("J♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Queen, Position.Null)).Returns("Q♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.King, Position.Null)).Returns("K♥");
                yield return new TestCaseData(new Card(Suit.Hearts, Rank.Ace, Position.Null)).Returns("A♥");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Two, Position.Null)).Returns("2♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Three, Position.Null)).Returns("3♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Four, Position.Null)).Returns("4♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Five, Position.Null)).Returns("5♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Six, Position.Null)).Returns("6♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Seven, Position.Null)).Returns("7♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Eight, Position.Null)).Returns("8♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Nine, Position.Null)).Returns("9♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Ten, Position.Null)).Returns("10♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Jack, Position.Null)).Returns("J♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Queen, Position.Null)).Returns("Q♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.King, Position.Null)).Returns("K♠");
                yield return new TestCaseData(new Card(Suit.Spades, Rank.Ace, Position.Null)).Returns("A♠");
            }
        }

        public static IEnumerable EqualsData
        {
            get
            {
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Null), new Card(Suit.Clubs, Rank.Ace, Position.Null)).Returns(true);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Null), new Card(Suit.Diamonds, Rank.Ace, Position.Null)).Returns(false);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Null), new Card(Suit.Clubs, Rank.King, Position.Null)).Returns(false);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Null), new Card(Suit.Diamonds, Rank.King, Position.Null)).Returns(false);
            }
        }

        public static IEnumerable EqualsWithPositionData
        {
            get
            {
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Hand), new Card(Suit.Clubs, Rank.Ace, Position.Flop)).Returns(false);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Hand), new Card(Suit.Diamonds, Rank.Ace, Position.Flop)).Returns(false);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Hand), new Card(Suit.Clubs, Rank.King, Position.Flop)).Returns(false);
                yield return new TestCaseData(new Card(Suit.Clubs, Rank.Ace, Position.Hand), new Card(Suit.Diamonds, Rank.King, Position.Flop)).Returns(false);
            }
        }
    }

    class HandData
    {
        public static IEnumerable RankingData
        {
            get
            {
                yield return new TestCaseData(GetPlayer(Suit.Clubs, Rank.Ace, Suit.Clubs, Rank.King), GetTable(Suit.Clubs, Rank.Queen, Suit.Clubs, Rank.Jack, Suit.Clubs, Rank.Ten, Suit.Hearts, Rank.Two, Suit.Hearts, Rank.Three)).Returns(Ranking.RoyalFlush);
                yield return new TestCaseData(GetPlayer(Suit.Diamonds, Rank.Nine, Suit.Diamonds, Rank.Eight), GetTable(Suit.Diamonds, Rank.Seven, Suit.Diamonds, Rank.Six, Suit.Diamonds, Rank.Five, Suit.Hearts, Rank.Two, Suit.Hearts, Rank.Three)).Returns(Ranking.StraightFlush);
                yield return new TestCaseData(GetPlayer(Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.Ace), GetTable(Suit.Hearts, Rank.Ace, Suit.Spades, Rank.Ace, Suit.Hearts, Rank.Two, Suit.Hearts, Rank.Three, Suit.Hearts, Rank.Four)).Returns(Ranking.FourOfAKind);
                yield return new TestCaseData(GetPlayer(Suit.Clubs, Rank.Queen, Suit.Diamonds, Rank.Queen), GetTable(Suit.Hearts, Rank.Queen, Suit.Spades, Rank.Jack, Suit.Hearts, Rank.Jack, Suit.Hearts, Rank.Three, Suit.Hearts, Rank.Four)).Returns(Ranking.FullHouse);
                yield return new TestCaseData(GetPlayer(Suit.Hearts, Rank.Ace, Suit.Hearts, Rank.Jack), GetTable(Suit.Hearts, Rank.Nine, Suit.Hearts, Rank.Six, Suit.Hearts, Rank.Three, Suit.Clubs, Rank.Two, Suit.Clubs, Rank.Three)).Returns(Ranking.Flush);
                yield return new TestCaseData(GetPlayer(Suit.Clubs, Rank.Nine, Suit.Diamonds, Rank.Eight), GetTable(Suit.Spades, Rank.Seven, Suit.Diamonds, Rank.Six, Suit.Spades, Rank.Five, Suit.Hearts, Rank.Two, Suit.Hearts, Rank.Three)).Returns(Ranking.Straight);
                yield return new TestCaseData(GetPlayer(Suit.Hearts, Rank.Two, Suit.Spades, Rank.Two), GetTable(Suit.Diamonds, Rank.Two, Suit.Clubs, Rank.Ace, Suit.Diamonds, Rank.King, Suit.Hearts, Rank.Queen, Suit.Spades, Rank.Jack)).Returns(Ranking.ThreeOfAKind);
                yield return new TestCaseData(GetPlayer(Suit.Hearts, Rank.Ace, Suit.Clubs, Rank.Ace), GetTable(Suit.Hearts, Rank.King, Suit.Spades, Rank.King, Suit.Hearts, Rank.Two, Suit.Clubs, Rank.Three, Suit.Diamonds, Rank.Four)).Returns(Ranking.TwoPair);
                yield return new TestCaseData(GetPlayer(Suit.Hearts, Rank.King, Suit.Clubs, Rank.Ace), GetTable(Suit.Hearts, Rank.King, Suit.Spades, Rank.Queen, Suit.Hearts, Rank.Two, Suit.Clubs, Rank.Three, Suit.Diamonds, Rank.Four)).Returns(Ranking.Pair);
                yield return new TestCaseData(GetPlayer(Suit.Hearts, Rank.Ace, Suit.Clubs, Rank.Five), GetTable(Suit.Hearts, Rank.Jack, Suit.Spades, Rank.King, Suit.Hearts, Rank.Two, Suit.Clubs, Rank.Three, Suit.Diamonds, Rank.Four)).Returns(Ranking.HighCard);
            }
        }

        private static Tuple<Card, Card> GetPlayer(Suit player1S, Rank player1R, Suit player2S, Rank player2R)
        {
            return new Tuple<Card, Card>(new Card(player1S, player1R, Position.Null), new Card(player2S, player2R, Position.Null));
        }

        private static Table GetTable(Suit table1S, Rank table1R, Suit table2S, Rank table2R, Suit table3S, Rank table3R, Suit table4S, Rank table4R, Suit table5S, Rank table5R)
        {
            Table retVal = new Table();
            retVal.AddFlop(table1S, table1R, table2S, table2R, table3S, table3R);
            retVal.AddTurn(table4S, table4R);
            retVal.AddRiver(table5S, table5R);
            return retVal;
        }
    }

    class TransactionData
    {
        public static IEnumerable EqualsData
        {
            get
            {
                yield return new TestCaseData(new Transaction(TransactionType.Give, 2000), new Transaction(TransactionType.Give, 2000)).Returns(true);
                yield return new TestCaseData(new Transaction(TransactionType.Give, 2000), new Transaction(TransactionType.Give, 1000)).Returns(false);
                yield return new TestCaseData(new Transaction(TransactionType.Give, 2000), new Transaction(TransactionType.Take, 1000)).Returns(false);
                yield return new TestCaseData(new Transaction(TransactionType.Give, 2000), new Transaction(TransactionType.Take, 1000)).Returns(false);
            }
        }
    }
}