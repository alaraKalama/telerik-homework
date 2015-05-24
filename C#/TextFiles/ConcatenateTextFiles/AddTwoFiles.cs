//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConcatenateTextFiles
{
    class AddTwoFiles
    {
        static void Main()
        {
            string firstPath = @"..\..\...\files\file1.txt";
            string secondPath = @"..\..\...\files\file2.txt";
            string newPath = @"..\..\...\files\fileConcat.txt";
            
            try
            {
                var readFirst = new StreamReader(firstPath);
                var readSecond = new StreamReader(secondPath);

                string FirstFile = readFirst.ReadToEnd();
                string SecondFile = readSecond.ReadToEnd();

                Console.WriteLine("Text in first file: {0}", FirstFile);
                Console.WriteLine("Text in second file: {0}", SecondFile);
                string text = FirstFile + SecondFile;
                
                var createFile = new StreamWriter(newPath);
                createFile.Close();
                Console.WriteLine();
                File.WriteAllText(newPath, text);

                Console.WriteLine("A new file ({0}) was created at {1}", Path.GetFileName(newPath), Path.GetFullPath(newPath));
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
