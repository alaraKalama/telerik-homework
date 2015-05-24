using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.
namespace SquareRoot
{
    class CalculateSquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);
                if (number < 0 || number > double.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}",number, result);
                
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
            }
            catch (ArgumentOutOfRangeException rangeEx)
            {
                Console.WriteLine(rangeEx.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
