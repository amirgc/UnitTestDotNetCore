using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    class BankAccount
    {
        public int balance;
        private readonly ILog log;
        public BankAccount(int amount, ILog log)
        {
            this.balance = amount;
            this.log = log;
        }

        internal bool Withdraw(int amountToWithdraw)
        {
            if (balance >= amountToWithdraw)
            {
                log.Write($"Successfully withdraw of amount {amountToWithdraw}");
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

