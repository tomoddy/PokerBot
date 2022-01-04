using PokerBot.Enums;

namespace PokerBot.Hands
{
    class FourOfAKind : Ranking, IRanking
    {
        public Strength Strength => Strength.FourOfAKind;
    }
}
