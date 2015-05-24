using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that can solve these tasks:
 - Reverses the digits of a number
 - Calculates the average of a sequence of integers
 - Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

namespace SolveTasks
{
    class SolveThreeTask
    {
        static void Main()
        {

            Console.WriteLine("To reverse the digits of your input     PRESS 1");
            Console.WriteLine("To calculate the average of the digits  PRESS 2");
            Console.WriteLine("To solve a linear equation              PRESS 3");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter number:");
                    string input = Console.ReadLine();
                    string result1 = ReversedNumber(input); 
                    Console.WriteLine("Reversed: {0}", result1);
                    break;

                case 2: 
                    Console.WriteLine("Enter numbers separated by a space:");
                    double[] numbersInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                    double result2 = Average(numbersInput);
                    Console.WriteLine("Result: {0}", result2);
                    break;

                case 3:  
                    Console.WriteLine("Enter a:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter b:");
                    double b = double.Parse(Console.ReadLine());
                    double result3 = SolveLinearEquasion(a, b);
                    Console.WriteLine("Result: {0}", result3);
                    break;

                default: Console.WriteLine("Invalid choice!"); break;
            }
           
        }

        static string ReversedNumber(string input)
        {
            char[] numbers = input.ToCharArray();
            Array.Reverse(numbers);
            return new string(numbers);
        }

        static double Average (double[] input)
        {
            double avarageOfNumbers = input.Average();
            return avarageOfNumbers;
        }

        static double SolveLinearEquasion(double a, double b)
        {
            double result = 0;
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Not very clever... Every x is solution.");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Not very clever again... a must be more than zero.");
            }
            else if (a < 0)
            {
                result = -b / a;
            }
            return result;
        }
    }
}
