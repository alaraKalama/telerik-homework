using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
namespace DateDifference
{
    class HowDays
    {
        static void Main()
        {
            Console.WriteLine("Enter first date(day.month. year):");
            DateTime first = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter second date(day.month. year):");
            DateTime second = DateTime.Parse(Console.ReadLine());
            int difference = 0;
            if (first < second)
            {
                difference = second.Subtract(first).Days;
            }
            else if (second < first)
            {
                Console.WriteLine("You should actually write the dates in opposite order but nah... Here you go:");
                difference = first.Subtract(second).Days;
            }

            Console.WriteLine("There are {0} days between the two dates.", difference.ToString());
        }
    }
}
