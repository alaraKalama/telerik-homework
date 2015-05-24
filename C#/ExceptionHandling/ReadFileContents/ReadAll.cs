using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileContents
{
    class ReadAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();
            try
            {
                string read = File.ReadAllText(path);
                Console.WriteLine(read);

            }
            catch(ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(PathTooLongException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(UnauthorizedAccessException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(NotSupportedException x)
            {
                Console.WriteLine(x.Message);
            }


        }
    }
}
