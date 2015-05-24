//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveSortedNames
{
    class Program
    {
        static void Main()
        {
            var read = new StreamReader(@"..\..\..\files\NamesList.txt");
            var list = read.ReadToEnd();
            //string[] names = list.Split(new char[] { '\n' });
            var sortNames = new SortedSet<string>(list.Split(new char[] { '\n', '\r', ' ', '\t' }));

            File.WriteAllLines(@"..\..\..\files\SortedNamesList.txt", sortNames);
            Console.WriteLine("A new file was created at {0}", Path.GetFullPath(@"..\..\..\files\SortedNamesList.txt"));
        }
    }
}
