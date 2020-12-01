using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTutorial
{
    public class BankAccount
    {
        private readonly string m_CustomerName;
        private double m_Balance;

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private BankAccount() { }

        public BankAccount(string CustomerName, double Balance)
        {
            m_CustomerName = CustomerName;
            m_Balance = Balance;
        }

        public string CustomerName{ get { return m_CustomerName; } }
        public double Balance { get { return m_Balance; } }

        public void Debit(double Amount)
        {
            if (Amount > m_Balance)
            {
                throw new System.ArgumentOutOfRangeException("Amount", DebitAmountExceedsBalanceMessage);
            }
            if (Amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Amount", DebitAmountLessThanZeroMessage);
            }

            m_Balance -= Amount; // Subtract from here, debit removes, credit adds
        }

        public void Credit(double Amount)
        {
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount");
            }
            m_Balance += Amount;
        }

    }
}
