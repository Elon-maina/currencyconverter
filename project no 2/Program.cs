using System;
using System.Collections.Generic;

class BankAccount
{
    public string AccountNumber { get; }
    public string AccountHolder { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of {amount:C} successful. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Account Balance for {AccountHolder} ({AccountNumber}): {Balance:C}");
    }
}

class BankManagementApp
{
    static List<BankAccount> accounts = new List<BankAccount>();

    static void Main()
    {
        Console.WriteLine("Bank Management Console Application");

        while (true)
        {
            Console.WriteLine("\n1. Create New Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    MakeDeposit();
                    break;
                case "3":
                    MakeWithdrawal();
                    break;
                case "4":
                    CheckAccountBalance();
                    break;
                case "5":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();

        Console.Write("Enter account holder name: ");
        string accHolder = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        if (double.TryParse(Console.ReadLine(), out double initialBalance))
        {
            BankAccount newAccount = new BankAccount(accNumber, accHolder, initialBalance);
            accounts.Add(newAccount);
            Console.WriteLine($"Account created successfully. Account number: {accNumber}");
        }
        else
        {
            Console.WriteLine("Invalid initial balance. Please enter a valid number.");
        }
    }

    static void MakeDeposit()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();

        BankAccount account = FindAccount(accNumber);

        if (account != null)
        {
            Console.Write("Enter deposit amount: ");
            if (double.TryParse(Console.ReadLine(), out double depositAmount))
            {
                account.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Account not found. Please check the account number.");
        }
    }

    static void MakeWithdrawal()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();

        BankAccount account = FindAccount(accNumber);

        if (account != null)
        {
            Console.Write("Enter withdrawal amount: ");
            if (double.TryParse(Console.ReadLine(), out double withdrawalAmount))
            {
                account.Withdraw(withdrawalAmount);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Account not found. Please check the account number.");
        }
    }

    static void CheckAccountBalance()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();

        BankAccount account = FindAccount(accNumber);

        if (account != null)
        {
            account.CheckBalance();
        }
        else
        {
            Console.WriteLine("Account not found. Please check the account number.");
        }
    }

    static BankAccount FindAccount(string accountNumber)
    {
        return accounts.Find(acc => acc.AccountNumber == accountNumber);
    }
}