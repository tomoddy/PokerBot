using PokerBot.Enums;
using System;

namespace PokerBot.Money
{
    /// <summary>
    /// Transaction object
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Type of transaction
        /// </summary>
        public TransactionType Type { get; private set; }

        /// <summary>
        /// Size of transaction
        /// </summary>
        public long Value { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="value">Value</param>
        public Transaction(TransactionType type, long value)
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Checks if transactions are equal
        /// </summary>
        /// <param name="transaction">Transaction to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public bool Equals(Transaction transaction)
        {
            return Type == transaction.Type && Value == transaction.Value;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Object as string</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case TransactionType.Give:
                    return $"+{Value}";
                case TransactionType.Take:
                    return $"-{Value}";
                default:
                    throw new Exception($"Invalid type \"{Type}\"");
            }
        }
    }
}