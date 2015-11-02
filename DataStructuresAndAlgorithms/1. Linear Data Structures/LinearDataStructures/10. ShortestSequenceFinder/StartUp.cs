namespace ShortestSequenceFinder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        // a second of appreciation for Pavel argidux who made this simple and elegant solution and 
        // once I saw it I couldn't unsee it. So thank you!
        static void Main()
        {
            int n = 5;
            int m = 16;
            var sequence = new StringBuilder();
            sequence.Insert(0, m.ToString());

            while(m != n)
            {
                m = FindNext(n, m);
                sequence.Insert(0, m.ToString() + " --> ");
            }

            Console.WriteLine(sequence.ToString());
        }

        private static int FindNext(int start, int target)
        {
            if(target / 2 >= start)
            {
                if(target % 2 != 0)
                {
                    return target - 1;
                }
                return target / 2;
            }
            if(target - 2 >= start)
            {
                return target - 2;
            }
            if(target - 1 >= start)
            {
                return target - 1;
            }
            return target;
        }
    }
}
