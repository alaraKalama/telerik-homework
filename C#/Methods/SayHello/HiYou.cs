using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//----------------------------------------------------------------------------
namespace SayHello
{
    class HiYou
    {
        static void Main()
        {
            Name();
        }

        private static void Name()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
