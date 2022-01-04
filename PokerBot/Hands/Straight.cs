using PokerBot.Enums;

namespace PokerBot.Hands
{
    class Straight : Ranking, IRanking
    {
        public Strength Strength => Strength.Straight;
    }
}
