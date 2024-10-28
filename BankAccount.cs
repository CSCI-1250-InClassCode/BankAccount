using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private readonly Logger _logger;
        public string AccountNumber { get; init; }
        public decimal Balance { get; private set; }
        public Person AccountHolder { get; private set; }

        public BankAccount(string accountNumber, decimal balance, Person accountHolder, Logger _logger)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.AccountHolder = accountHolder;

            this._logger = _logger;
            this._logger.Log($"Created a new account for {accountHolder.FirstName} {accountHolder.LastName} with " +
                $"account number: {accountNumber} with a balance of {balance} in the BankAccount Class");
        }
        public BankAccount(string accountNumber, decimal balance, string firstName, string lastName, string dob, Logger _logger)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            AccountHolder = new Person(firstName, lastName, dob);

            this._logger = _logger;
            this._logger.Log($"Created a new account for {AccountHolder.FirstName} {AccountHolder.LastName} with " +
                $"account number: {accountNumber} with a balance of {balance} in the BankAccount Class");
        }
    }
}
