namespace SortInIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Write a program that reads a sequence of integers (List<int>) ending with an empty line
    //and sorts them in an increasing order.
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of positive integers separated by space");
            List<int> numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => int.Parse(e))
                .ToList();

            numbers.Sort();
            Console.WriteLine("Sorted numbers: {0}", string.Join(", ", numbers));
        }
    }
}
