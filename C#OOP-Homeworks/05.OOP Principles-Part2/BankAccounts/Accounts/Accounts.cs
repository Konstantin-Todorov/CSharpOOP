namespace BankAccounts.Accounts
{
    using BankAccounts.Coustomers;
    using BankAccounts.Interfaces;
    using System;

    public abstract class Accounts : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Accounts(Customer customer,decimal balance , decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.interestRate = value; 
            }
        }
        
        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.balance = value; 
            }
        }


        public Customer Customer
        {
            get { return this.customer; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.customer = value;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException();
            }

            return months * this.InterestRate;
        }
    }
}
