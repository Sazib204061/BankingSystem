using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        protected string AccountHolderName { get; set; }
        protected double Balance { get; set; }

        public void CreateAccount(ref Dictionary<int, SavingsAccount> Accounts)  //create regular account
        {
            

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Number:");
                    AccountNumber = Convert.ToInt32(Console.ReadLine());

                    if(Accounts.ContainsKey(AccountNumber))
                    {
                        Console.WriteLine("Account Number already exists. Please enter a different Account Number.");
                        continue;
                    }

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
        }

        public void Deposit(double DepositAmount)
        {
            Balance += DepositAmount;
            Console.WriteLine("Deposited $" + DepositAmount + ".\nNew Balance: $" + Balance);
        }

        public void Withdraw(double WithdrawAmount)
        {
            if (WithdrawAmount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= WithdrawAmount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("New Balance: $" + Balance);
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine("Account Number : "+AccountNumber);
            Console.WriteLine("Account Holder Name : "+AccountHolderName);
            Console.WriteLine("Balance : "+Balance);
        }

    }
}
