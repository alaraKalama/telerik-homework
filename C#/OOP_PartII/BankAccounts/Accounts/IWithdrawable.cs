using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    interface IWithdrawable
    {
        decimal Withdraw(decimal sum);
    }
}
