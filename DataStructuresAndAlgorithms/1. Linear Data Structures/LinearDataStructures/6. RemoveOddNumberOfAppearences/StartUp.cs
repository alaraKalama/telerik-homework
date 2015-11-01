namespace RemoveOddNumberOfAppearences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<int> sequence = new List<int>{ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var filterOddAppearences = sequence.GroupBy(x => x).Where(x => x.Count() % 2 == 0);
            List<int> removedOddAppearences = new List<int>();
            foreach(var group in filterOddAppearences)
            {
                removedOddAppearences.AddRange(group);
            }

            Console.WriteLine("initial list: {0}", string.Join(", ", sequence));
            Console.WriteLine("after removing odd appearences: {0}", string.Join(", ", removedOddAppearences));
        }
    }
}
