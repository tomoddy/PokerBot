using PokerBot.Enums;

namespace PokerBot.Hands
{
    class StraightFlush : Ranking, IRanking
    {
        public Strength Strength => Strength.StraightFlush;
    }
}
