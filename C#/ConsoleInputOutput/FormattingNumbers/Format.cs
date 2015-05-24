/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

using System;

namespace FormattingNumbers
{
    class Format
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("                 RESULT:\n");
            Console.WriteLine("{0, -10}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}", Convert.ToString(a, 16), Convert.ToString(a, 2), b, c);

        }
    }
}
