using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BankAccounts
{
    class Loan : Account
    {
        public Loan(string _name, Customer _customer, double _balance, double _interestRate)
        {
            name = _name;
            customer = _customer;
            balance = _balance;
            interestRate = _interestRate;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (customer == Customer.Company)
            {
                if(months > 2)
                {
                    return ((double)months - 2) * interestRate; 
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 3)
                {
                    return ((double)months - 3) * interestRate;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
