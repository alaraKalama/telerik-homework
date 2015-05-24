using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class ConvertToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter binary number:");
            string binary = Console.ReadLine();
            int[] binArray = new int[binary.Length];
            int decResult = 0;
            int power = 1;
            string negative = " ";

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                binArray[i] = binary[i] - 48;
            }

            
                if (binArray.Length == 4 || binArray.Length == 8 || 
                    binArray.Length == 16 || binArray.Length == 32 ||
                    binArray.Length == 64)
                {
                    for (int i = binary.Length - 1; i > 0; i--)
                    {
                        if (binArray[0] == 1)
                        {
                            negative = "-";
                        }

                        decResult += (binArray[i] * power);
                        power *= 2;
                    }
                }
                else
                {
                    for (int i = binary.Length - 1; i >= 0; i--)
                    {
                        decResult += (binArray[i] * power);
                        power *= 2;
                    }
                }

            Console.WriteLine("{0}{1}", negative, decResult);
        }
    }
}
