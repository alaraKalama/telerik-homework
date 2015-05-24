//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReplaceSubstring
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\..\files\SubstringOutput.txt";
            string outputPath = @"..\..\..\files\WordOutput.txt";

            try
            {
                var reader = new StreamReader(path);
                string text = reader.ReadToEnd();
                string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r' });
                StringBuilder outputBuild = new StringBuilder();

                using (reader)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i] ==  "penis")
                        {
                            words[i] = "hair";
                        }
                        outputBuild.Append(words[i] + ' ');
                    }
                }

                string output = outputBuild.ToString();
                //using (var write = new StreamWriter(outputPath))
                //{
                File.WriteAllText(outputPath, output);
                Console.WriteLine("Success! A new file: {0}, was created at {1}",
                    Path.GetFileNameWithoutExtension(outputPath), Path.GetFullPath(outputPath));
                //}
            }
            catch (FileLoadException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
                Console.WriteLine("To run this program, first you should run ReplaceSubstring program.");
            }
            catch (DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
