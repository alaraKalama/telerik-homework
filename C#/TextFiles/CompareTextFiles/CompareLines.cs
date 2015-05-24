//Write a program that compares two text files line by line and prints the number of 
//lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompareTextFiles
{
    class CompareLines
    {
        static void Main()
        {
            string thePath = @"..\..\...\files\";
            Console.WriteLine("There are these files in directory {0}:", Path.GetFullPath(thePath));
            var files = Directory.EnumerateFileSystemEntries(thePath);

            foreach(string file in files)
            {
                string currentFile = file.Substring(16);
                Console.WriteLine(currentFile);
            }

            Console.WriteLine("Please choose which two files you like to compare:");
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.WriteLine("File 1:");
                    string file1 = Console.ReadLine();
                    string path1 = @"..\..\...\files\" + file1;
                    var read1 = new StreamReader(path1);

                    Console.WriteLine("File 2:");
                    string file2 = Console.ReadLine();
                    string path2 = @"..\..\...\files\" + file2;
                    var read2 = new StreamReader(path2);

                    var text1 = read1.ReadToEnd();
                    string[] lines1 = text1.Split(new char[] { '\n' });
                    int countLines1 = lines1.Count();

                    var text2 = read2.ReadToEnd();
                    string[] lines2 = text2.Split(new char[] { '\n' });
                    int countLines2 = lines2.Count();

                    int maxLines = 0;
                    int minLines = 0;
                    if (countLines1 > countLines2)
                    {
                        maxLines = countLines1;
                        minLines = countLines2;
                    }
                    else
                    {
                        maxLines = countLines2;
                        minLines = countLines1;
                    }

                    int sameLines = 0;
                    int diffLines = maxLines - minLines;

                    for (int j = 0; j <= minLines-1; j++)
                    {
                        if (lines1[j] == lines2[j])
                        {
                            sameLines++;
                        }
                        else
                        {
                            diffLines++;
                        }
                    }
                    Console.WriteLine("There are {0} equal lines.", sameLines);
                    Console.WriteLine("There are {0} different lines.", diffLines);

                    break;
                }
                    
                catch (FileNotFoundException x)
                {
                    Console.WriteLine(x.Message);
                    if (i == 2)
                    {
                        Console.WriteLine("Restart the program.");
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
        }
    }
}
