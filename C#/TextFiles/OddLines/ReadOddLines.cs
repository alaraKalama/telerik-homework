//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class ReadOddLines
    {
        static void Main()
        {
           
            var reader = new StreamReader(@"..\..\..\files\oddLines.txt");
            try
            {
                using (reader)
                {
                    int counter = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        counter++;
                        if (counter % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(FileLoadException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(EndOfStreamException x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
