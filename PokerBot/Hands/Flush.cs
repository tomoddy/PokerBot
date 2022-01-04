using PokerBot.Enums;

namespace PokerBot.Hands
{
    class Flush : Ranking, IRanking
    {
        public Strength Strength => Strength.Flush;
    }
}
