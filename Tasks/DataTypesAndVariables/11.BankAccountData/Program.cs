using System;

namespace _11.BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, middleName, lastName;
            double balance;
            string bankName;
            string IBAN;
            string[] creditCard = new string[3];

            firstName = "Yordan";
            middleName = "Valentinov";
            lastName = "Petkov";
            balance = 896.35;
            bankName = "Raiffeisenbank";
            IBAN = "BG13RZBB96520326456723";
            creditCard[0] = "4894769856893265";
            creditCard[1] = "6593";
            creditCard[2] = "495";

            string creditCardFirstDig = "";

            Console.WriteLine("Holder name : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Balance : {0}", balance);
            Console.WriteLine("Bank : {0}, IBAN : {1}", bankName, IBAN);

            for (int i = 0; i < 4; i++)
            {
                creditCardFirstDig += creditCard[0][i];
            }

            Console.WriteLine("Credit card : {0}************", creditCardFirstDig);


        }
    }
}
