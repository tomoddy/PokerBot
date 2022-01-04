using PokerBot.Enums;

namespace PokerBot.Hands
{
    class TwoPair : Ranking, IRanking
    {
        public Strength Strength => Strength.TwoPair;
    }
}
