using PokerBot.Enums;

namespace PokerBot.Hands
{
    class HighCard : Ranking, IRanking
    {
        public Strength Strength => Strength.HighCard;
    }
}
