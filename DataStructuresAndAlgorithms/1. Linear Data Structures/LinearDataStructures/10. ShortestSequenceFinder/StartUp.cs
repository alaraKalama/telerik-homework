namespace ShortestSequenceFinder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int n = 5;
            int m = 16;
            Queue<int> sequence = new Queue<int>();
            FindShortestSequence(n, m, sequence);
        }

        public static void FindShortestSequence(int start, int target, Queue<int> sequence)
        {
            sequence.Enqueue(start);
            
            while(start < target)
            {
                if (start + 1 == target)
                {
                    start += 1;
                    sequence.Enqueue(start);
                    PrintSequence(sequence);
                    break;
                }
                if (start + 2 == target)
                {
                    start += 2;
                    sequence.Enqueue(start);
                    PrintSequence(sequence);
                    break;
                }
                if (start * 2 > target)
                {
                    while (start < target)
                    {
                        start += 2;
                        sequence.Enqueue(start);
                    }
                    FindShortestSequence(start, target, sequence);
                }
                else if(start * 2 == target)
                {
                    start *= 2;
                    sequence.Enqueue(start);
                    PrintSequence(sequence);
                    break;
                }
                else if(start * 2 < target)
                {
                    FindShortestSequence(start, target, sequence);
                }
            }
        }

        public static void PrintSequence(Queue<int> sequence)
        {
            Console.WriteLine(string.Join("-->", sequence));
        }
    }
}
