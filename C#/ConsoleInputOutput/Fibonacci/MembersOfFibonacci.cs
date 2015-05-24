//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

namespace Fibonacci
{
    class MembersOfFibonacci
    {
        static void Main()
        {
            Console.WriteLine("How many Fibonacci sequence members you need?");
            int n = int.Parse(Console.ReadLine());
            int member = 0;
            int nextMember = 1;
       
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} \n", member);
                int sum = member + nextMember;
                member = nextMember;
                nextMember = sum;
            }
        }
    }
}
