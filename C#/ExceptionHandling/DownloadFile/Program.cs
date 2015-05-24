using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace DownloadFile
{
    class Program
    {
        const string url = "http://www.highpants.net/wp-content/uploads/2014/03/highpants-ascii-art-cow.jpg";
        const string name = "AsciiCow.png";

        static void Main()
        {
            try
            {
                WebClient newWeb = new WebClient();
                newWeb.DownloadFile(url, name);
                Console.WriteLine("The picture is saved at {0}.", Directory.GetCurrentDirectory());
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
