using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    class BankAccount
    {
        public int balance;

        public BankAccount(int v)
        {
            this.balance = v;
        }

        internal bool Withdraw(int amountToWithdraw)
        {
            if (balance >= amountToWithdraw)
            {
                balance -= amountToWithdraw;
                return true;
            }
            return false;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            balance += amount;

        }
    }
}

