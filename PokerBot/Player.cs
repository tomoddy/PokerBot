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
        private Tuple<Card, Card> Cards { get; set; }

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
            Cards = null;
            Wallet = new Wallet(stack);
        }

        /// <summary>
        /// Getter for cards
        /// </summary>
        /// <returns>Hand tuple</returns>
        public Tuple<Card, Card> GetCards()
        {
            return Cards;
        }

        /// <summary>
        /// Give player a card
        /// </summary>
        /// <param name="card">Card to give</param>
        public void GiveCard(Card card)
        {
            if (Cards == null)
                Cards = new Tuple<Card, Card>(card, null);
            else if (Cards.Item2 == null)
                Cards = new Tuple<Card, Card>(Cards.Item1, card);
            else
                throw new Exception("Hand is full");
        }

        /// <summary>
        /// Clear player cards
        /// </summary>
        /// <returns>Players hand</returns>
        public Tuple<Card, Card> ClearCards()
        {
            Tuple<Card, Card> temp = Cards;
            Cards = null;
            return temp;
        }

        /// <summary>
        /// Get player hand combined with table
        /// </summary>
        /// <param name="table">Table</param>
        /// <returns>Hand</returns>
        public Hand GetHand(Table table)
        {
            return new Hand(this, table);
        }
    }
}