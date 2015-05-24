//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

namespace ExtractBit3
{
    class PositionThreeBit
    {
        static void Main()
        {
            Console.WriteLine("Ënter a positive real number:");
            int n = int.Parse(Console.ReadLine());
            int p = 3;                 // 00000000 00000011
            int mask = 1 << p;         // 00000000 00001000
            int maskAndN = n & mask;   
            int bit = maskAndN >> p;
            Console.WriteLine("The binary representation is {0}", Convert.ToString(n, 2));
            Console.WriteLine("The bit in position 3 is {0}", bit);
            
        }
    }
}
