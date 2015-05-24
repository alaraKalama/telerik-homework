using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UnicodeCharacters
{
    class ConvertToUnicode
    {
        static void Main()
        {
            Console.WriteLine("Enter something:");
            string input = Console.ReadLine();
            byte[] uniByte = Encoding.Unicode.GetBytes(input);
            StringBuilder unicode = new StringBuilder();
            double uniChar;
            foreach(byte b in uniByte)
            {
                if (b == 0)
                {
                    continue;
                }
                unicode.Append("\\u" + b.ToString("X").PadLeft(4, '0'));
            }

            Console.WriteLine(unicode.ToString());
        }
    }
}
