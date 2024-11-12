using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
        {
            private decimal _balance;
            private const decimal MinimumBalance = 100m;
            public AccountOwner Owner { get; }

            public Account(decimal initialDeposit, AccountOwner owner)
            {
                if (initialDeposit < MinimumBalance)
                {
                    throw new ArgumentException($"The initial deposit must be at least {MinimumBalance:C}.");
                }

                _balance = initialDeposit;
                Owner = owner ?? throw new ArgumentNullException(nameof(owner), "Account owner cannot be null.");
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }

                _balance += amount;
                Console.WriteLine(GenerateUpdateMessage()); // Print the update message
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                if (_balance - amount < MinimumBalance)
                {
                    throw new InvalidOperationException("Insufficient funds. Cannot withdraw below minimum balance.");
                }

                _balance -= amount;
                Console.WriteLine(GenerateUpdateMessage()); // Print the update message
            }

            public decimal GetBalance()
            {
                return _balance;
            }

            // Private method to generate update message
            private string GenerateUpdateMessage()
            {
                return $"Din konto er blevet opdateret. Der står nu kr. {_balance:C}.";
            }
        }
    }

