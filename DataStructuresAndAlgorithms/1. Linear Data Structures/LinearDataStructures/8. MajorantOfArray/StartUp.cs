namespace _8.MajorantOfArray
{
    // *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    //Write a program to find the majorant of given array (if exists).

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int majorant = (numbers.Length / 2) + 1;
            var occuranceCounts = numbers.GroupBy(x => x).OrderBy(x => x.Key);
            int? majorantOfNumbers = null;

            foreach(var group in occuranceCounts)
            {
                if(group.Count() == majorant)
                {
                    majorantOfNumbers = group.ElementAt(0);
                }
            }

            if (majorantOfNumbers == (int?)null)
            {
                Console.WriteLine("No majorant in this array!");
            }
            else
            {
                Console.WriteLine("Majorant is {0}", majorantOfNumbers);
            }
            
        }
    }
}
