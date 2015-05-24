//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

namespace CheckBitPosition
{
    class BitAtPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a number and press Enter:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position you want to check:");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int nAndMask = n & mask;
            int result = nAndMask >> p;
            bool ifOne = result == 1;
            Console.WriteLine("The bit in position #{0} is 1 --->{1}", p, ifOne);
        }
    }
}
