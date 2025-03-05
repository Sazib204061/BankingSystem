// See https://aka.ms/new-console-template for more information

using Banking_System;

Dictionary<int, SavingsAccount> Accounts = new Dictionary<int, SavingsAccount>();
//delegate bool myDelegate(int Number);

while (true)
{
    Console.WriteLine("\n\nSimple Banking System\n");
    Console.WriteLine("1.Create Account\n2.Deposit\n3.Withdraw\n4.Check Balance\n5.Apply Interest (Savings Account)\n6.Filter Accounts\n7.Exit");

    var choice = Console.ReadLine();
    if(choice=="7")
    {
        break;
    }

    if (choice == "1")   //Account Creation
    {
        int AccountType;
        Console.WriteLine("Enter Account Type(1-Regular, 2-Savings):");
        AccountType = Convert.ToInt32(Console.ReadLine());

        Func<int, bool> myDelegate = (Number) => (Number == 1);

        if (myDelegate(AccountType))   //regular account create
        {
            var RegularAccount = new SavingsAccount();
            RegularAccount.CreateAccount(ref Accounts);

            Accounts.Add(RegularAccount.AccountNumber, RegularAccount);

            Console.WriteLine("Regular Account Created Successfully.\n");
        }
        else
        {
            var SavingsAccount = new SavingsAccount();
            SavingsAccount.CreateAccount(ref Accounts,true);           //apply popymorphism in CreateAccount method
            Accounts.Add(SavingsAccount.AccountNumber, SavingsAccount);
            Console.WriteLine("Savings Account Created Successfully.\n");
        }
    }
    else if (choice == "2")   //Deposit
    {
        while (true)
        {

            int AccountNumber;
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

            if(!Accounts.ContainsKey(AccountNumber))
            {
                Console.WriteLine("Invalid Account Number. Please enter a valid Account number.");
                continue;
            }

            double DepositAmount;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Amount to Deposit:");
                    DepositAmount = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Amount. Please enter a valid Amount.");
                }
            }
            bool flag = false;

            try     
            {
                var CurrentAccount = Accounts[AccountNumber];
                CurrentAccount.Deposit(DepositAmount);
                break;
            }
            catch (Exception e)
            {
                flag = true;
                Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
            }
            if (flag == false) break;
        }
    }
    else if (choice == "3")    //Withdraw
    {
        BankAccount CurrentAccount = new SavingsAccount();
        while (true)
        {
            int AccountNumber;
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
            if (!CurrentAccount.IsAccountExists(ref Accounts, AccountNumber))
            {
                Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
                continue;
            }

            CurrentAccount = Accounts[AccountNumber];


            double WithdrawAmount;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Amount to Withdraw:");
                    WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Amount. Please enter a valid Amount.");
                }
            }

            CurrentAccount.Withdraw(WithdrawAmount);
            break;
            
        }
        
    }
    else if (choice == "4")   //Check Balance
    {
        BankAccount CurrentAccount = new SavingsAccount();
        while (true)
        {
            int AccountNumber;
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

            if(!CurrentAccount.IsAccountExists(ref Accounts, AccountNumber))
            {
                Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
                continue;
            }
            else
            {
                CurrentAccount = Accounts[AccountNumber];
                CurrentAccount.CheckBalance();
                break;
            }
            //bool flag = false;
            //try
            //{
            //    var CurrentAccount = Accounts[AccountNumber];
            //    CurrentAccount.CheckBalance();
            //    break;
            //}
            //catch (Exception e)
            //{
            //    flag = true;
            //    Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
            //}
            //if (flag == false) break;
        }


        //Console.WriteLine("Enter Account Number :");
        //int AccountNumber = Convert.ToInt32(Console.ReadLine());
        //var CurrentAccount = Accounts[AccountNumber];
        //CurrentAccount.CheckBalance();
    }

    else if(choice == "5")   //Apply Interest
    {

        while (true)
        {
            int AccountNumber;
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
            bool flag = false;
            try
            {
                var CurrentAccount = Accounts[AccountNumber];
                CurrentAccount.ApplyInterest();
                break;
            }
            catch (Exception e)
            {
                flag = true;
                Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
            }
            if (flag == false) break;
        }



        //Console.WriteLine("Enter Account Number:");
        //int AccountNumber = Convert.ToInt32(Console.ReadLine());        
        //var CurrentAccount = Accounts[AccountNumber];
        //CurrentAccount.ApplyInterest();
    }
    else if(choice == "6")   //filter
    {
        SavingsAccount account = new SavingsAccount();
        account.FilterAccounts(ref Accounts);
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }

}