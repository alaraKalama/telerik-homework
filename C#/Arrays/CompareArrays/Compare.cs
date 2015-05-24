//Write a program that reads two integer arrays from the console and
//compares them element by element.

using System;

namespace CompareArrays
{
    class Compare
    {
        static void Main()
        {

            #region allocate arrays
            Console.WriteLine("How many element you wish array 1 to have?");
            int n1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[n1];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter value for element {0} in array 1:", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("How many element you wish array 2 to have?");
            int n2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[n2];

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Enter value for element {0} in array 2:", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            #endregion

            bool[] equality = new bool[array2.Length];
            bool areEqual = false;

            if (array1.Length != array2.Length)
            {
                Console.WriteLine();
            }

            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        equality[i] = true;
                    }
                }
                foreach (bool value in equality)
                {
                    if (value == false)
                    {
                        areEqual = false;
                        break;
                    }
                    if (value == true)
                    {
                        areEqual = true;
                    }
                }
            }

            if (areEqual == true)
            {
                Console.WriteLine("The two arrays are equal.");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal.");
            }
        }
    }
}
