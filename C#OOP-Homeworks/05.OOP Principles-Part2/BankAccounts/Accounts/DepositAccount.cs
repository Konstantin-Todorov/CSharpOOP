
namespace BankAccounts.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankAccounts.Interfaces;
    using BankAccounts.Coustomers;

    public class DepositAccount : Accounts ,IWithdrawable,IDepositable
    {
        public DepositAccount(Customer customer , decimal balance , decimal interestRate)
            : base(customer,balance,interestRate)
        {

        }

        public void Withdraw(decimal ammount)
        {
            if (ammount > this.Balance)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.Balance -= ammount;
        }

        public override decimal CalculateInterest(int numOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                throw new ArgumentException();
            }

            return base.CalculateInterest(numOfMonths);
        }

        internal void WithdrawAmount(int p)
        {
            throw new NotImplementedException();
        }
    }
}
