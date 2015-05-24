using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************************************************************************************
//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).
//*******************************************************************************************************

namespace SortByStringLength
{
    class SortArrayByLenght
    {
        static void Main()
        {
            Console.WriteLine("Enter elements(string) of array separated by a space:");
            string[] stringArray = Console.ReadLine().Split(' ').ToArray();

            SortByLenght(stringArray);

            foreach(string str in SortByLenght(stringArray))
            {
                Console.WriteLine("{0} ", str);
            }
             
        }

        static IEnumerable<string> SortByLenght (IEnumerable<string> stringArray)
        {
            var sorted = from c in stringArray
                         orderby c.Length ascending
                         select c;
            return sorted;
        }
    }
}
