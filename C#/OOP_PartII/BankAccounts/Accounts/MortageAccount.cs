using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    public class MortageAccount :Account
    {
        private const int CompanyMortageInterest = 12;
        private const int IndividualMortageInterest = 6;

        public MortageAccount(Customer client, decimal balance, decimal interest)
            : base (client, balance, interest)
        {
            this.Type = AccountType.Mortage;
        }

        public override decimal InterestAmount(int months)
        {
            if (this.Client.Type == Customers.CustomerType.Individual)
            {
                if (months >= IndividualMortageInterest)
                {
                    return (months - 6) * this.InterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months <= CompanyMortageInterest)
                {
                    return (months * this.InterestRate) / 2;
                }
                else
                {
                    int monthsToFollow = months - CompanyMortageInterest;
                    return ((CompanyMortageInterest * this.InterestRate) / 2) + (monthsToFollow * InterestRate);
                    //I think this should be correct:D.
                }
            }
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "\nAccount type: " + this.Type);
        }
    }
}
