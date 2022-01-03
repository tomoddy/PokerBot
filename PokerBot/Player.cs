using PokerBot.Enums;
using PokerBot.Money;
using System;

namespace PokerBot
{
    /// <summary>
    /// Player object
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Id of player
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Name of player
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Wallet of player
        /// </summary>
        public Wallet Wallet { get; private set; }

        /// <summary>
        /// Cards in hand of player
        /// </summary>
        public Tuple<Card, Card> Hand { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id">Id of player</param>
        /// <param name="name">Name of player</param>
        /// <param name="stack">Size of starting stack</param>
        public Player(int id, string name, long stack)
        {
            Id = id;
            Name = name;
            Hand = null;
            Wallet = new Wallet(stack);
        }

        /// <summary>
        /// Give player a card
        /// </summary>
        /// <param name="card">Card to give</param>
        public void Give(Card card)
        {
            if (Hand == null)
                Hand = new Tuple<Card, Card>(card, null);
            else if (Hand.Item2 == null)
                Hand = new Tuple<Card, Card>(Hand.Item1, card);
            else
                throw new Exception("Hand is full");
        }

        /// <summary>
        /// Clear player hand
        /// </summary>
        /// <returns>Players hand</returns>
        public Tuple<Card, Card> Clear()
        {
            Tuple<Card, Card> temp = Hand;
            Hand = null;
            return temp;
        }
    }
}