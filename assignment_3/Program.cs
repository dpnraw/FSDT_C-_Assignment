using System;
namespace assignment_3
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Create a checking account
            BankAccount checkingAccount = new BankAccount();
            Console.WriteLine("Before opening Chequeing Account.");
            Console.WriteLine($"Checking Account: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}, Type: {checkingAccount.Type}");
            
            checkingAccount.Deposit(500m);
            checkingAccount.Withdraw(200m);

            Console.WriteLine("After calling Deposit and Withdraw Method.");
            Console.WriteLine($"Checking Account: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}, Type: {checkingAccount.Type} \n");

            // Create a savings account
            BankAccount savingsAccount = new BankAccount(654321, 2000m);
            Console.WriteLine($"Savings Account: {savingsAccount.AccountNumber}, Balance: {savingsAccount.Balance:C}, Type: {savingsAccount.Type}");

            savingsAccount.Deposit(1000m);
            savingsAccount.Withdraw(3000m);

            Console.ReadKey();
        }
    }
}

