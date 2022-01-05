using Humanizer;
using PokerBot.Enums;

namespace PokerBot.Hands
{
    /// <summary>
    /// Ranking interface
    /// </summary>
    public interface IRanking
    {
        /// <summary>
        /// Hand strength
        /// </summary>
        Strength Strength { get; }

        /// <summary>
        /// Get ranking as text
        /// </summary>
        public string Text => $"{Strength}".Humanize(LetterCasing.Title);
    }
}