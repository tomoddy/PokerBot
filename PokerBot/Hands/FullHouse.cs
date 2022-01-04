using PokerBot.Enums;

namespace PokerBot.Hands
{
    class FullHouse : Ranking, IRanking
    {
        public Strength Strength => Strength.FullHouse;
    }
}
