using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
namespace CanadaTime
{
    class DatesInCanada
    {
        static void Main()
        {
            Console.WriteLine("Enter something with dates in it:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                                CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");
                    Console.WriteLine("Canada (french): {0}", date.Date.ToLongDateString());

                }
                catch (FormatException)
                {
                }
            }
            
        }
    }
}
