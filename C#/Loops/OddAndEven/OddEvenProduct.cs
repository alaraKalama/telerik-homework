/*You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/
using System;

namespace OddAndEven
{
    class OddEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers in a single line, separated by space:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] {'\u0020'}, StringSplitOptions.RemoveEmptyEntries);
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int element = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= element;
                }
                if (i % 2 != 0)
                {
                    oddProduct *= element;
                }
            }
            bool isEqual = evenProduct == oddProduct;
            Console.WriteLine(isEqual ? "Yes" : "No");
            Console.WriteLine("Even product: {0}\nOdd product: {1}", evenProduct, oddProduct);
        }
    }
}
