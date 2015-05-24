/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            //First create user-friendly input options:
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("     int --------> 1");
            Console.WriteLine("     double -----> 2");
            Console.WriteLine("     string -----> 3");
            //Then read the user's input:
            int input = int.Parse(Console.ReadLine());

            //Use switch to do the three possible inputs:
            switch(input)
            {
                case 1:
                    Console.WriteLine("Enter int:");
                    int i = int.Parse(Console.ReadLine());
                    i++;
                    Console.WriteLine(i++); break;
                case 2:
                    Console.WriteLine("Enter double:");
                    double d = double.Parse(Console.ReadLine());
                    d++;
                    Console.WriteLine(d); break;
                case 3:
                    Console.WriteLine("Enter string:");
                    string s = Console.ReadLine();
                    Console.WriteLine("{0}*",s); break;
                 // And use a default case if the user enter int > 3 and < 1
                default: Console.WriteLine("Invalid input!"); break;
            }

        }
    }
}
