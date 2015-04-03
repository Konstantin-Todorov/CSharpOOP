namespace BankAccounts.Accounts
{
    using BankAccounts.Coustomers;
    using BankAccounts.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MortgageAccount : Accounts , IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer,balance,interestRate)
        {

        }

        public override decimal CalculateInterest(int numOfMonths)
        {
            if (numOfMonths < 0)
            {
                throw new ArgumentException();
            }
            if (this.Customer is IndividualCustomer)
            {
                numOfMonths -= 6;
            }
            else if (this.Customer is CompanieCustomer)
            {
                if (numOfMonths <= 12)
                {
                    return 0.5m * base.CalculateInterest(numOfMonths);
                }
                else
                {
                    decimal result = 0.5m * base.CalculateInterest(12);
                    result += base.CalculateInterest(numOfMonths - 12);
                    return result;
                }
            }
            if (numOfMonths < 0)
            {
                return 0;
            }

            return base.CalculateInterest(numOfMonths);
        }
    }
}
