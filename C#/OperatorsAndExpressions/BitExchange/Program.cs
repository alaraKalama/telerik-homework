//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            //First we enter a number and see it's binary representation. 
            Console.WriteLine("Write a real number and press Enter:");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of your number is:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            //For the sake of illustration I will asume that the entered number is 1140867093 and comment about it.
            
            //Binary representation is:                                                      // 0100 0100 0000 0000 0100 0000 0001 0101

            //Step 1 - create two masks that have 1-s in the position 3,4,5 and 24, 25 and 26.
            //First finding those values with calculator
            uint mask345 = 56u;                                                              // 0000 0000 0000 0000 0000 0000 0011 1000
            uint mask242526 = 117440512u;                                                    // 0000 0111 0000 0000 0000 0000 0000 0000

            //Step 2 - see values of the bits 
            uint bits345 = n & mask345;                                                      // 0000 0000 0000 0000 0000 0000 0001 0000
            uint bits242526 = n & mask242526;                                                // 0000 0100 0000 0000 0000 0000 0000 0000

            //Step 3 - shift bits with 21 positions in both directions
            bits345 = bits345 << 21;                                                         // 0000 0010 0000 0000 0000 0000 0000 0000
            bits242526 = bits242526 >> 21;                                                   // 0000 0000 0000 0000 0000 0000 0010 0000

            //Step 4 - set 0 value for those bits
            n = n & (~mask345);                                           //~mask345         // 1111 1111 1111 1111 1111 1111 1100 0111
                                                                          //n & (~mask345)   // 0100 0100 0000 0000 0100 0000 0000 0101
            n = n & (~mask242526);                                        //~mask242526 //   // 1111 1000 1111 1111 1111 1111 1111 1111
                                                                          //n & (~mask242526)// 0100 0000 0000 0000 0100 0000 0001 0101

            //Step 5 - apply
            n = n | bits345;                                              //bits345          // 0000 0010 0000 0000 0000 0000 0000 0000 
                                                                          //|n               // 0100 0010 0000 0000 0100 0000 0001 0101
            n = n | bits242526;                                           //bits242526       // 0000 0000 0000 0000 0000 0000 0010 0000
                                                                          //|n               // 0100 0010 0000 0000 0100 0000 0010 0101

            Console.WriteLine("The result in binary is:\n{0}", Convert.ToString(n, 2).PadLeft(32,'0'));
            Console.WriteLine("This stands for {0}", n);
        }
    }
}
