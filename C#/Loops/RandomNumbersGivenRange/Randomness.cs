//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

namespace RandomNumbersGivenRange
{
    class Randomness
    {
        static void Main()
        {
            Console.WriteLine("Enter max value:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min value:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many random numbers between {0} and {1} you need:", min, max);
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            Random rnd = new Random();
            for (int i = 1; i <= n; i++)
            {
                result = rnd.Next(min, max);
                Console.WriteLine(result);
            }
            
        }
    }
}
