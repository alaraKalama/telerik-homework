//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

namespace DividingBool
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter a real number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} {1} be devided by 5 and 7 at the same time.", number, Devide (number) ? "can":"can't");
        }
            static bool Devide (int number)
            {
                if (number % 7 == 0 && number % 5 == 0)
                {
                    return true;
                }
                return false;
            }
    }
}
