using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequent
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int times = 0;
            int mostFrequent = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 1;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counter++;

                            if (counter > times)
                            {
                                times = counter;
                                mostFrequent = numbers[i];
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.Write("{0} ({1} times)", mostFrequent, times);
        }
    }
}
