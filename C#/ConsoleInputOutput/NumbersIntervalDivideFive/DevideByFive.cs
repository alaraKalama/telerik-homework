//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0.

using System;

namespace NumbersIntervalDivideFive
{
    class DevideByFive
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter number b:");
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            int first = 0;
            int last = 0;

            if(a>b)
            {
                first = b;
                last = a;
            }
            else
            {
                first = a;
                last = b;
            }

            for(int i = first; i<last; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                    Console.WriteLine("{0}", counter);
                }
            }
            Console.WriteLine("There are {0} numbers between {1} and {2}, which when devided by 5 have reminder 0", counter, first, last);
        }
    }
}
