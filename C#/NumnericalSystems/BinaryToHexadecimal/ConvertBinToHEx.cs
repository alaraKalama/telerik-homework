using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class ConvertBinToHex
    {
        static void Main()
        {
            Console.WriteLine("Enter binary:");
            string binary = Console.ReadLine();
            string hexa = BinToHexadecimal(binary);
            Console.WriteLine(hexa);
        }

        static string BinToHexadecimal (string binary)
        {
            string hexa = Convert.ToInt64(binary, 2).ToString("X");
            return hexa;
        }
    }
}
