using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class Program
    {
        static void Main()
        {
            try
            {
                ushort number = ushort.Parse(Console.ReadLine());
                Console.WriteLine(ToBinary(number));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string ToBinary(ushort s)
        {
            string bin = String.Empty;
            for (int i = 0; i < 16; i++)
            {
                bin = (s >> i & 1) + bin;
            }
            return bin;
        }
    }
}
