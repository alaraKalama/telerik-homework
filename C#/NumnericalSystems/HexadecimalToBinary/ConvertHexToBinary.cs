using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HexadecimalToBinary
{
    class ConvertHexToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal:");
            string hexValue = Console.ReadLine();
            string binary = HexToBinary(hexValue);
            Console.WriteLine(binary);
        }

        static string HexToBinary (string hexValue)
        {
            string binary = String.Join(String.Empty, hexValue.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            return binary;
        }
    }
}
