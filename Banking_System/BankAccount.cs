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

        public void CreateAccount()  //create regular account
        {

            Console.WriteLine("Enter Account Number:");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name:");
            AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter Initial Balance:");
            Balance = Convert.ToDouble(Console.ReadLine());
            
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
