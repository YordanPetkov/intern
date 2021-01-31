using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BankAccounts
{
    enum Customer
    {
        Individual,
        Company
    }
    abstract class Account
    {
        protected string name;
        protected Customer customer;
        protected double balance;
        protected double interestRate;

        public abstract double CalculateInterestAmount(int months);
        public void DepositAmount(double _money)
        {
            balance += _money;
            Console.WriteLine(name + " : ");
            Console.WriteLine("Current balance : {0}.", balance);
        }
    }
}
