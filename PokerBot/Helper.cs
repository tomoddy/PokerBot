using System.Collections.Generic;

namespace PokerBot
{
    /// <summary>
    /// Helper class
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// To string method for enumerables
        /// </summary>
        /// <param name="enumerable">Enumerable</param>
        /// <returns>Formatted string list</returns>
        public static string FormatList<T>(List<T> values)
        {
            return $"({string.Join(", ", values)})";
        }
    }
}