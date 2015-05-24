//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class CopyNumberLines
    {
        static void Main()
        {
            try
            {
                var read = new StreamReader(@"..\..\...\files\ThinkLikeAProgrammer.txt", Encoding.UTF8);
                var write = new StreamWriter(@"..\..\...\files\ThinkLikeAProgrammerCopy.txt");

                string line = read.ReadLine();
                int lineNumber = 1;

                while (line != null)
                {
                    write.WriteLine("{0:D2}. {1}", lineNumber, line);
                    line = read.ReadLine();
                    lineNumber++;
                }

                Console.WriteLine("A new file {0} was created at {1}",
                        Path.GetFileName(@"..\..\...\files\ThinkLikeAProgrammerCopy.txt"), Path.GetFullPath(@"..\..\...\files\ThinkLikeAProgrammerCopy.txt"));
                Console.WriteLine();
                Console.WriteLine(@"NOTE: Appearantly on my computer the text is overwritten only till line 42, no idea why. When debugging
                                everything works till the end but the final file doesn't have all the lines. Maybe 42 is just the best possible answer.");
                Console.WriteLine("And the book is quite good:)");
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
