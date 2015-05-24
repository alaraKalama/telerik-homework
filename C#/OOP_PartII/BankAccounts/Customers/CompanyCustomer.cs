using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Customers
{
    class CompanyCustomer : Customer
    {
        private string companyName;

        public CompanyCustomer(string companyName, string firstname, string lastname)
            : base (firstname, lastname) 
        {
            this.CompanyName = companyName;
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public override string ToString()
        {
            return String.Format
                ("Account holder: " +  this.CompanyName + "\n" +
                      ", MRP: " + this.Firstname + " " + this.Lastname + "\n" +
                                  "Contact info: " + this.Email + ", " + this.Email);
        }

    }
}
