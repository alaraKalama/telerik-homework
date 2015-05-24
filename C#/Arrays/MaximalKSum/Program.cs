using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.
//-------------------------------------------------------------------------------------------------------

namespace MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialize
            Console.WriteLine("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter value for element {0} in array:", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            int seq = numbers.Length - k;

           #endregion

            Array.Sort(numbers);

            for (int i = numbers.Length - 1; i >= seq; i--)
            {
                Console.Write("{0} ", numbers[i]);
            }
            
           
        }
    }
}
