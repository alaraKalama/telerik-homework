//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

using System;

namespace FourDigitNumber
{
    class SwitchDigits
    {
        static void Main()
        {
            Console.WriteLine("Enter a four-digit number:");
            int number = int.Parse(Console.ReadLine());

            if (number > 9999 || number < 1000)
            {
                Console.WriteLine("Not a four-digit number!!!");
            }
            else
            {
                int d = number % 10;
                number /= 10;
                int c = number % 10;
                number /= 10;
                int b = number % 10;
                number /= 10;
                int a = number % 10;
                number /= 10;

                //int sum = a + b + c + d;
                //int reversedOrder = d * 1000 + c * 100 + b * 10 + a;
                //int lastIsFirst = d * 1000 + a * 100 + b * 10 + c;
                //int exchange2and3 = a * 1000 + c * 100 + b * 10 + d;

                Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
                Console.WriteLine("Digits in reversed order: {0}{1}{2}{3}", d, c, b, a);
                Console.WriteLine("Last digit comes first: {0}{1}{2}{3}", d, a, b, c);
                Console.WriteLine("Exchange 2nd and 3rd digit: {0}{1}{2}{3}", a, c, b, d);
            }
        }
    }
}
