﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    public interface IDepositable
    {
         void Deposit(decimal sum);
    }
}