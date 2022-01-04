using PokerBot.Enums;

namespace PokerBot.Hands
{
    class RoyalFlush : Ranking, IRanking
    {
        public Strength Strength => Strength.RoyalFlush;
    }
}
