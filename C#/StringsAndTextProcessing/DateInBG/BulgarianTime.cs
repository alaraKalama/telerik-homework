using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
namespace DateInBG
{
    class BulgarianTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in format: day.month.year hour:minute:second");
            string input = Console.ReadLine().Trim();
            DateTime date = DateTime.Parse(input);
            var culture = new CultureInfo("bg-BG");

            DateTime newDate = date.AddHours(6).AddMinutes(30);
            var DayOfWeek = culture.DateTimeFormat.GetDayName(newDate.DayOfWeek);
            Console.WriteLine("After six hours and 30 minutes it will be: {0}, {1}", newDate, DayOfWeek);
        }
    }
}
