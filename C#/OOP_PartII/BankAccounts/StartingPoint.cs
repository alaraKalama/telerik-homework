using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts;
using BankAccounts.Customers;

namespace BankAccounts
{
    class StartingPoint
    {
        static void Main()
        {
            Bank KTB = new Bank("KTB", "unknown adress");
            Customer TsvetanVasilev = new Customer("Tsvetan", "Vasilev");
            DepositAccount accountCvetanVasilev = new DepositAccount(TsvetanVasilev , 10000000.99m, 30m);
            Customer Vivacom = new CompanyCustomer("VivacomOOD", "Delyan", "Peevski");
            LoanAccount accountVivacom = new LoanAccount(Vivacom, 700000m, 30m);

            Console.WriteLine(accountCvetanVasilev.ToString());
            Console.WriteLine("Interest amount for 1 year: {0}", accountCvetanVasilev.InterestAmount(12));
            accountCvetanVasilev.Withdraw(10000000.99m);
            Console.WriteLine(accountCvetanVasilev.ToString());

        }
    }
}
