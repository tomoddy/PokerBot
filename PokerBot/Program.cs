namespace PokerBot
{
    class Program
    {
        static void Main()
        {
            TexasHoldEm game = new(4, 2000);
            game.Start();
        }
    }
}