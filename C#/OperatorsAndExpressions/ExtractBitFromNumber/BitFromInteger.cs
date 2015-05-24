//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

namespace ExtractBitFromNumber
{
    class BitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter a real number and press Enter:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit you want to extract:... and press Enter.");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int nAndMask = n & mask;
            int result = nAndMask >> p;
            Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2));
            Console.WriteLine("Bit in position {0} is {1}", p, result);
        }
    }
}
