using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class AccountOwner
    {
        public int CustomerId { get; }
        public string _firstName;
        public string _lastName; 

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                UpdateFullName();
            }
        }
            public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                UpdateFullName();
            }
        }
            public string FullName { get; private set; }

        public AccountOwner(int customerId, string firstName, string lastName)
        {
            if (customerId < 100000 || customerId > 999999)
            {
                throw new ArgumentException("Customer ID must be a 6-digit number.");

            }
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            UpdateFullName();
        }
        private void UpdateFullName()
        { 
            FullName = $"{FirstName} {LastName}"; 
        }
    }   
}
