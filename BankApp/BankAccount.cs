using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        public int Id { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Negative deposit amount is not allowed");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
