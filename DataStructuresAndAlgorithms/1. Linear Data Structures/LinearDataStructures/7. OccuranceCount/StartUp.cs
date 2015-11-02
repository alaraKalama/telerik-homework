namespace OccuranceCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var occuranceCounts = numbers.GroupBy(x => x).OrderBy(x => x.Key);

            foreach(var items in occuranceCounts)
            {
                Console.WriteLine("{0} occures {1} times", items.Key, items.Count());
            }
        }
    }
}
