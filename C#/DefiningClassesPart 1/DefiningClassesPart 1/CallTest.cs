using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart_1
{
    public class CallTest
    {
        public void HistoryTest(GSM phone)
        {
            phone.AddCall(new Call(DateTime.Now.AddMinutes(30), "0875432123", 50));
            phone.AddCall(new Call(DateTime.Now.AddHours(21), "0888888888", 34));
            phone.AddCall(new Call(DateTime.Now.AddDays(1), "0887456345", 156));
            phone.AddCall(new Call(DateTime.Now.AddDays(3), "0899334667", 600));

            phone.DisplayHistory(phone);

            decimal price = phone.CallsPrice();
            Console.WriteLine("total calls price: {0:F2}", price);
            Console.WriteLine();

            phone.RemoveLongestCall();

            phone.DisplayHistory(phone);

            price = phone.CallsPrice();
            
            Console.WriteLine("total calls price: {0:F2}", price);
            Console.WriteLine();
            
            phone.ClearHistory();
            
            phone.DisplayHistory(phone);


            

        }
    }
}
