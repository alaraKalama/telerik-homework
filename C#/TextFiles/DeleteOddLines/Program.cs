//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathIn = @"..\..\..\files\oddLinesCopy.txt";
            string pathOut = @"..\..\..\files\oddLinesCopy.txt";
            var reader = new StreamReader(pathIn);

            try
            {
                StringBuilder result = new StringBuilder();

                using (reader)
                {
                    int counter = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        counter++;
                        if (counter % 2 != 0)
                        {
                            line = string.Empty;
                        }
                        result.Append(line + '\n');
                        line = reader.ReadLine();
                    }
                }
                string newFile = result.ToString();
                File.WriteAllText(pathOut, newFile);
                Console.WriteLine("Success! The file was overwritten without odd lines!");
            }
            catch (DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (FileLoadException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (EndOfStreamException x)
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
