using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    
    public class DepositAccount : Account
    {
        public DepositAccount(Customer client, decimal balance, decimal interest)
            : base (client, balance, interest)
        {
            this.Type = AccountType.Deposit;
        }

        public override decimal Withdraw(decimal sum)
        {
            return this.Balance -= sum;
        }
        
        public override decimal InterestAmount(int months)
        {
            if(this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }

            return months * this.InterestRate;
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "\nAccount type: " + this.Type);
        }
    }
}
