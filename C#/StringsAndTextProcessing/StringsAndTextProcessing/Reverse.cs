using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndTextProcessing
{
    class Reverse
    {
        static void Main()
        {
            Console.WriteLine("Enter something:");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            Console.WriteLine(inputArray);
        }
    }
}
