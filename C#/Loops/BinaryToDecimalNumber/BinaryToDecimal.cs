using System;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter number in binary:");
            string binary = Console.ReadLine();
            long decimalResult = 0;
            int power = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                int element = binary[i] - 48;
                if (element == 1)
                {
                    decimalResult += element * power;
                }
                power *= 2;
            }
            Console.WriteLine("{0} in decimal is {1}", binary, decimalResult);
        }
    }
}
