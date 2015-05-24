using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

namespace FormatNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("decimal:               {0:F2}", input);
            Console.WriteLine("hexadecimal:           {0:X}", input);
            Console.WriteLine("percentage:            {0:P}", input);
            Console.WriteLine("scientific notation:   {0:E}", input);
        }
    }
}
