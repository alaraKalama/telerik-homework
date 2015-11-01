namespace PositiveIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    // Write a program that reads from the console a sequence of positive integer numbers.
    // The sequence ends when empty line is entered.
    // Calculate and print the sum and average of the elements of the sequence.
    // Keep the sequence in List<int>.

    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of positive integers separated by space");
            // although there is nothing about how to separate the numbers and I had difficulties 
            // understanding how the input is going to come:)
            List<int> numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => int.Parse(e))
                .ToList();

            Console.WriteLine("The sum of all numbers is: {0}", numbers.Sum());
            Console.WriteLine("Average of all numbers is: {0}", numbers.Average());

        }
    }
}
