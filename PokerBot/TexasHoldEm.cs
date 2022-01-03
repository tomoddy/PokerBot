using System;
using System.Collections.Generic;

namespace PokerBot
{
    class TexasHoldEm
    {
        private Deck Deck { get; set; }

        private List<Player> Players { get; set; }

        public Table Table { get; private set; }

        public TexasHoldEm(int playerCount, long startingStack)
        {
            if (playerCount > 1)
            {
                Deck = new Deck();
                Players = new List<Player>();
                Table = new Table();

                for (int i = 1; i <= playerCount; i++)
                {
                    Console.WriteLine($"Player {i} name? : ");
                    //Players.Add(new Player(i, Console.ReadLine()));
                    Players.Add(new Player(i, $"PlayerName{i}", startingStack));
                }
            }
            else
            {
                throw new Exception($"Invalid player count \"{playerCount}\"");
            }
        }

        public void Start()
        {
            Deal();
            Hand hand = new Hand(Players[0].Hand, Table);
            Console.WriteLine(hand.Ranking);
        }

        public void Deal()
        {

            for (int i = 0; i < 2; i++)
            {
                foreach (Player player in Players)
                {
                    player.Give(Deck.Draw());
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" | ", Table);
        }
    }
}