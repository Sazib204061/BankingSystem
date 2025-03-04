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
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Number:");
                    AccountNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Account Number. Please enter a valid Account number.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Holder Name:");
                    AccountHolderName = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Account Holder Name. Please enter a valid Account Holder Name.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Initial Balance:");
                    Balance = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Balance. Please enter a valid Balance.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Interest Rate(%):");
                    InterestRate = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Interest Rate. Please enter a valid Interest Rate.");
                }
            }
        }

        public void ApplyInterest()
        {
            if(InterestRate == 0)
            {
                Console.WriteLine("Invalid Account Number!!!. Please enter a valid Account number.");
                return;
            }
            Balance += Balance * (InterestRate / 100);
            Console.WriteLine("Interest Applied. New Balance: $" + Balance);
        }


    }
}
