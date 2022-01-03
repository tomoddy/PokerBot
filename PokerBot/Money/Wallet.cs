using PokerBot.Enums;
using System.Collections.Generic;

namespace PokerBot.Money
{
    /// <summary>
    /// Wallet object
    /// </summary>
    public class Wallet
    {
        /// <summary>
        /// Stack size
        /// </summary>
        public long Stack { get; private set; }

        /// <summary>
        /// List of transactions
        /// </summary>
        private List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Number of transactions
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return Transactions.Count;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="stack">Starting stack</param>
        public Wallet(long stack)
        {
            Stack = 0;
            Transactions = new List<Transaction>();
            Give(stack);
        }

        /// <summary>
        /// Give chips to player
        /// </summary>
        /// <param name="value">Value of chips</param>
        /// <returns>True if valid and complete, false if value <= 0</returns>
        public bool Give(long value)
        {
            if (value > 0)
            {
                Stack += value;
                Transactions.Add(new Transaction(TransactionType.Give, value));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Take chips from player
        /// </summary>
        /// <param name="value">Value of chips</param>
        /// <returns>True if valid and complete, false if value <= 0 or stack < value</returns>
        public bool Take(long value)
        {
            if (value > 0 && Stack - value >= 0)
            {
                Stack -= value;
                Transactions.Add(new Transaction(TransactionType.Take, value));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Get transaction at index
        /// </summary>
        /// <param name="index">Index of transaction</param>
        /// <returns>Transaction at index</returns>
        public Transaction GetTransaction(int index)
        {
            return Transactions[index];
        }
    }
}