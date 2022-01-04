using PokerBot.Enums;

namespace PokerBot.Hands
{
    class Pair : Ranking, IRanking
    {
        public Strength Strength => Strength.Pair;
    }
}
