//Write an if-statement that takes two double variables a and b and exchanges their values if 
//the first one is greater than the second one. As a result print the values a and b, separated by a space.
using System;

namespace ExchangeIfGreater
{
    class ExchangingGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter a double variable a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a double variable b:");
            double b = double.Parse(Console.ReadLine());

            //first scenario: a is bigger -> exchange values.
            //to exchange values you need a temporal variable to hold the value of a
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            //second scenario: don't exchange -> do nothing, just print the result.
            Console.Write(a + " " + b);
        }
    }
}
