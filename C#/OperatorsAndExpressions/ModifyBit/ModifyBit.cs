/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
 * at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position of bit:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value:");
            int v = int.Parse(Console.ReadLine());

            if (v == 1)
            {
                int mask = 1 << p;
                int result = n | mask;
                string binaryN = Convert.ToString(n, 2);
                string binaryResult = Convert.ToString(result, 2);

                Console.WriteLine("Your number is {0}",n);
                Console.WriteLine("It's binary representation is {0}", binaryN);
                Console.WriteLine("When you set the value of bit at position #{0} to {1}", p, v);
                Console.WriteLine("Your result in binary is {0}", binaryResult);
                Console.WriteLine("This represents the number {0}", result);
            }
            else if (v == 0)
            {
                int mask = ~(1<<p);
                int result = n & mask;
                string binaryN = Convert.ToString(n, 2);
                string binaryResult = Convert.ToString(result, 2);

                Console.WriteLine("Your number is {0}", n);
                Console.WriteLine("It's binary representation is {0}", binaryN);
                Console.WriteLine("When you set the value of bit at position #{0} to {1}", p, v);
                Console.WriteLine("Your result in binary is {0}", binaryResult);
                Console.WriteLine("This represents the number {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
