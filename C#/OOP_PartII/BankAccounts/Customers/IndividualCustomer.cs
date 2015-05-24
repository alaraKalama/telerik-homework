using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Customers
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string firstname, string lastname, CustomerType type)
            : base (firstname, lastname)
        {
            this.Type = CustomerType.Individual;
        }
    }
}
