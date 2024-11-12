using System;
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var owner = new AccountOwner(123456, "John", "Doe");

                var account = new Account(150, owner);

                Console.WriteLine($"Account created for {owner.FirstName} {owner.LastName} (ID: {owner.CustomerId})");
                Console.WriteLine($"Initial balance: {account.GetBalance():C}");

                account.Withdraw(50);
                Console.WriteLine($"Balance after withdrawl: {account.GetBalance():C}");

                account.Withdraw(75);
                Console.WriteLine($"Balance after withdrawl: {account.GetBalance()}:C");

                account.Withdraw(50);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }   
}