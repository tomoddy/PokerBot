using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerBot
{
    class TexasHoldEm
    {
        private const int HAND_SIZE = 2;

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
                    //Console.WriteLine($"Player {i} name? : ");
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
            // Deal cards
            Deal();

            // Preflop
            PrintHands();

            // Flop
            Table.AddFlop(Deck.Draw(), Deck.Draw(), Deck.Draw());
            PrintHands();

            // Turn
            Table.AddTurn(Deck.Draw());
            PrintHands();

            // River
            Table.AddRiver(Deck.Draw());
            PrintHands();
        }

        public void Deal()
        {
            for (int i = 0; i < HAND_SIZE; i++)
                foreach (Player player in Players)
                    player.GiveCard(Deck.Draw());
        }

        public void PrintHands()
        {
            Console.WriteLine(Helper.FormatList(Table.Cards));
            foreach (Player player in Players.OrderByDescending(player => player.GetHand(Table).Ranking.Strength))
            {
                Hand hand = new(player, Table);
                Console.WriteLine($"{player.Name} - {player.GetCards()} ({hand.Ranking.Text})");
            }
        }

        public override string ToString()
        {
            return string.Join(" | ", Table);
        }
    }
}