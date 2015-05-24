//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;

//-------------------------------------------------------------------------------------------------------
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
//-------------------------------------------------------------------------------------------------------

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int[] allocatedArray = new int[20];
            for (int index = 0; index < allocatedArray.Length; index++)
            {
                allocatedArray[index] = index * 5;
                Console.WriteLine("element[{0}] = {1}", index, allocatedArray[index]);
            }
            
        }
    }
}
