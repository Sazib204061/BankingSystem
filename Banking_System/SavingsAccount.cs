using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class SavingsAccount : BankAccount
    {
        private double InterestRate { get; set; }


        public void CreateAccount(int x)      //CreateAccount method Overloaded with and Parameter. Create Savings Account
        {
            Console.WriteLine("Enter Account Number:");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name:");
            AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter Initial Balance:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate(%):");
            InterestRate = Convert.ToDouble(Console.ReadLine());
        }

        public void ApplyInterest()
        {
            Balance += Balance * (InterestRate / 100);
            Console.WriteLine("Interest Applied. New Balance: $" + Balance);
        }


    }
}
