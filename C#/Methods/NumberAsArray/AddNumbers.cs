//Write a method that adds two positive integer numbers represented as arrays
//of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first positive integer number: ");
        string a = Console.ReadLine();

        Console.Write("Enter second positive integer number: ");
        string b = Console.ReadLine();

        Console.WriteLine(AddNumbers(a, b)); 
    }                                                              

    static string AddNumbers(string a, string b)
    {
        string result = "";
        int lengthDifference = Math.Max(a.Length, b.Length) 
            - Math.Min(a.Length, b.Length);                 
        
        if (a.Length > b.Length)
        {
            b = new string('0', lengthDifference) + b;
        }
        else
        {
            a = new string('0', lengthDifference) + a;
        }
        int remainder = 0;
        int number = 0;
        for (int i = 0; i < a.Length; i++)
        {

            number = int.Parse(a[a.Length - 1 - i].ToString()) +
                         int.Parse(b[b.Length - 1 - i].ToString()) + remainder;
            remainder = number / 10;

            if (number % 10 != 0)
            {
                result = number % 10 + result;
            }
            else
            {
                result = 0 + result;
            }

            if (i == a.Length - 1 && remainder == 1)
            {
                result = remainder + result;
            }
        }

        return result;
    }
}