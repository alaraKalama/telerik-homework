using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number.
//Example:

// input	    output
// 256	        652
// 123.45	    54.321
namespace ReverseNumber
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to be reversed:");
            string input = Console.ReadLine();
            string result = ReversedNumber(input);
            Console.WriteLine("Reversed: {0}", result);

        }

        static string ReversedNumber(string input)
        {
            char[] numbers = input.ToCharArray();
            Array.Reverse(numbers);
            return new string(numbers);
                
        }
    }
}
