
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;

namespace ThirdDigit
{
    class Third7
    {
        static void Main()
        {
            Console.WriteLine("Enter a real number:");
            int number = int.Parse(Console.ReadLine());
            number /= 100;
            bool ThirdDigitSeven = (number % 10 == 7);
            Console.WriteLine("The third digit is{0} seven.", ThirdDigitSeven ? " ":" not");

        }
    }
}
