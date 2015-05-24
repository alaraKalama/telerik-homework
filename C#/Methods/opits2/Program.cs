using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
namespace NumberAsArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            string inputA = Console.ReadLine();
            int[] a = ConvertToArray(inputA);

            Console.WriteLine("Enter second number:");
            string inputB = Console.ReadLine();
            int[] b = ConvertToArray(inputB);

            int[] result = Addition(a, b);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", result[i]);
            }
        }

        static int[] ConvertToArray(string input)
        {
            int aLenght = input.Length;
            int[] a = new int[aLenght];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = input[i] - 48;
            }

            return a;
        }

        static int[] Addition(int[] a, int[] b)
        {
            Array.Reverse(a);
            Array.Reverse(b);
            int[] result = new int[0];
            int difference = 0;

            if (a.Length > b.Length)
            {
                difference = a.Length - b.Length;
                result = new int[a.Length];
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    result[i] = a[i] + b[i];
                }
                for (int i = b.Length; i < b.Length + difference; i--)
                {
                    result[i] = a[i];
                }
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] > 10)
                    {
                        result[i + 1] = result[i] + result[i / 10];
                        result[i] = result[i % 10];
                    }
                }
            }
            else if (b.Length > a.Length)
            {
                difference = b.Length - a.Length;
                result = new int[b.Length];
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    result[i] = b[i] + a[i];
                }
                for (int i = a.Length; i < a.Length + difference; i--)
                {
                    result[i] = b[i];
                }

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] > 10)
                    {
                        result[i + 1] = result[i] + result[i / 10];
                        result[i] = result[i % 10];
                    }
                }
            }
            Array.Reverse(result);
            return result;
        }

    }
}