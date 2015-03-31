
namespace BankAccounts.Accounts
{
    using BankAccounts.Coustomers;
    using BankAccounts.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LoanAccount : Accounts,IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
                numOfMonths -= 3;
            }
            else if (this.Customer is CompanieCustomer)
            {
                numOfMonths -= 2;
            }
            if (numOfMonths < 0)
            {
                return 0;
            }

            return numOfMonths * this.InterestRate;
        }
    }
}
