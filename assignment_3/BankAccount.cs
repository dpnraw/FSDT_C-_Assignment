using System;

namespace assignment_3
{
    public class BankAccount
    {
        // class members
        private int accountNumber;
        private decimal balance;
        private AccountType type; 

        // parameterless constructor for checking account
        public BankAccount() : this(0, 0m, AccountType.Checking)
        {
        }

        // constructor with parameters for saving account
        public BankAccount(int accountNumber, decimal initialBalance) : this(accountNumber, initialBalance, AccountType.Saving)
        {
        }

        // private constructor with all parameters
        private BankAccount(int accountNumber, decimal initialBalance, AccountType type)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            Type = type;
        }

        // property for accessing and mutating
        public int AccountNumber {  
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public decimal Balance { get { return balance; } private set {  balance = value; } }

        public AccountType Type { get { return type; } private set {  type = value; } }

        // deposit method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }

            Balance += amount;
        }

        // withdraw method
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }
    }

    public enum AccountType
    {
        Checking,
        Saving
    }
}


