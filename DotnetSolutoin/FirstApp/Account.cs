using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {
        private float balance;
        public Account(float balance)
        {
            this.balance = balance;
        }

        public void SetBalance(float balance)
        { 
            this.balance = balance; 
        }
        public float GetBalance()
        {
            return balance;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

    }
}
