using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumnericalSystems
{
    class ConvertToBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number:");
            int decInput = int.Parse(Console.ReadLine());
            string binary = DecToBinary(decInput);
            Console.WriteLine("{0} in binary: {1}", decInput, binary);
        }

        static string DecToBinary(int decInput)
        {
            string binary = Convert.ToString(decInput, 2).PadLeft(32, '0');
            return binary;
        }
    }
}
