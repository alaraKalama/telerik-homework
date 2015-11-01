namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<int> sequence = new List<int>{3, 5, 4, -3, 7, -8, 0, 6, -8};
            for(int i = 0; i < sequence.Count; i++)
            {
                if(sequence[i] < 0)
                {
                    sequence.Remove(sequence[i]);
                }
            }
            Console.WriteLine("Removed negative numbers!");
            Console.WriteLine(string.Join(", ", sequence));

        }
    }
}
