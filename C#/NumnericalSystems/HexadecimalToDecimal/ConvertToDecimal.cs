using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace HexadecimalToDecimal
{
    class ConvertToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter hexadecimal number:");
            string hexValue = Console.ReadLine();
            int decValue = HexToDecimal(hexValue);
            Console.WriteLine("In decimal: {0}", decValue);
        }
        static int HexToDecimal (string hexValue)
        {
            int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            return decValue;
        }
    }
}
