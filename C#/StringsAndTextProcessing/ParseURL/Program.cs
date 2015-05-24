using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	                                                          
//http://telerikacademy.com/Courses/Courses/Details/212

//info
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

namespace ParseURL
{
    class Program
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            int indexProtocol = url.IndexOf('/');
            string protocol = url.Remove(indexProtocol + 2);
            string server = url.Substring(indexProtocol + 2);
            int indexServer = server.IndexOf('/');
            server = server.Remove(indexServer);
            int indexDot = url.IndexOf('.');
            string resource = url.Substring(indexDot);
            int res = resource.IndexOf('/');
            resource = resource.Substring(res);


            Console.WriteLine("[protocol]:   {0}", protocol);
            Console.WriteLine("[server]:     {0}", server);
            Console.WriteLine("[resource]:   {0}", resource);

        }
    }
}
