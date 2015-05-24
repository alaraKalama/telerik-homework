//Write an expression that checks if given integer is odd or even.

using System;

namespace Odd_or_Even_Integers
{
    class OddOrEven
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a real number:");
            int number = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("The number {0} is {1}.",number, IsEven(number) ? "even" : "odd");
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }

    }
}
