using PokerBot.Enums;

namespace PokerBot.Hands
{
    class ThreeOfAKind : Ranking, IRanking
    {
        public Strength Strength => Strength.ThreeOfAKind;
    }
}
