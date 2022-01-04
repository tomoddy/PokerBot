using PokerBot.Enums;

namespace PokerBot.Hands
{
    public interface IRanking
    {
        Strength Strength { get; }

        string ToString()
        {
            return Strength.ToString();
        }
    }
}