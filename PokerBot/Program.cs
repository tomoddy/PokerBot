namespace PokerBot
{
    class Program
    {
        static void Main()
        {
            TexasHoldEm game = new TexasHoldEm(4, 2000);
            game.Start();
        }
    }
}