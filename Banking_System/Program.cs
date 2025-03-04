// See https://aka.ms/new-console-template for more information

using Banking_System;

Dictionary<int, SavingsAccount> Accounts = new Dictionary<int, SavingsAccount>();

while (true)
{
    Console.WriteLine("\n\nSimple Banking System\n");
    Console.WriteLine("1.Create Account\n2.Deposit\n3.Withdraw\n4.Check Balance\n5.Apply Interest (Savings Account)\n6.Exit");

    var choice = Console.ReadLine();
    if(choice=="6")
    {
        break;
    }

    if (choice == "1")   //Account Creation
    {
        int AccountType;
        Console.WriteLine("Enter Account Type(1-Regular, 2-Savings):");
        AccountType = Convert.ToInt32(Console.ReadLine());

        if (AccountType == 1)   //regular account create
        {
            var RegularAccount = new SavingsAccount();
            RegularAccount.CreateAccount();

            Accounts.Add(RegularAccount.AccountNumber, RegularAccount);

            Console.WriteLine("Regular Account Created Successfully.\n");
        }
        else if(AccountType == 2) //savings account create
        {
            var SavingsAccount = new SavingsAccount();
            SavingsAccount.CreateAccount(2);           //apply popymorphism in CreateAccount method
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
            bool flag = false;
            try
            {
                var CurrentAccount = Accounts[AccountNumber];
                CurrentAccount.Withdraw(WithdrawAmount);
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
    else if (choice == "4")   //Check Balance
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
                CurrentAccount.CheckBalance();
                break;
            }
            catch (Exception e)
            {
                flag = true;
                Console.WriteLine("Account NotFound!!!. Please enter a valid Account number.");
            }
            if (flag == false) break;
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
    else
    {
        Console.WriteLine("Invalid Choice");
    }

}