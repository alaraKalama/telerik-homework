//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

namespace NumberCompare
{
    class Bigger
    {
        static void Main()
        {
            Console.WriteLine("NUMBER COMPARER\nEnter two numbers to compare!");
            Console.WriteLine("Enter number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            int b = int.Parse(Console.ReadLine());
            // if a is bigger than b, this bool is true, if not the bool is false.
            bool isBigger = a < b;
            //this syntax gives the placeholder {2} the value of the bool and checks(?) if it is true - 
            //if true the first thing after the ? is printed, if not - the second, and the two are separated by :
            Console.WriteLine("{0} {2} {1}", a, b, isBigger ? "<":">");
        }
    }
}
