using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DecimalToHexadecimal
{
    class CovertToHexa
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number:");
            int decInput = int.Parse(Console.ReadLine());
            string hexa = DecToHexadecimal(decInput);
            Console.WriteLine("{0} in hexadecimal: {1}", decInput, hexa);
        }

        static string DecToHexadecimal (int decInput)
        {
            string hexa = Convert.ToString(decInput, 16);
            return hexa;
        }
    }
}
