using System;

namespace BeerTime
{
    class Beer
    {
        static void Main()
        {
            Console.WriteLine("At what time are you interested in drinking beer?\n(Enter time in hh:mm tt format):");
            string timeString = Console.ReadLine();
            DateTime time;
            
            // beerTime
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");
            bool beer = DateTime.TryParse(timeString, out time);
            bool beerTime = true;
            if(beer)
            {
                if (time > start || time < end)
                {
                    beerTime = true;
                }
                else
                {
                    beerTime = false;
                }
                Console.WriteLine("The time is {0}.", beerTime ? "BEER TIME" : "NON BEER TIME");
                if (time == start)
                {
                    Console.WriteLine("But almost BEER TIME. Stay strong!");
                }
            }
            else
            {
                Console.WriteLine("How many beers you had already?");
            }

            
        }
    }
}
