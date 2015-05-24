//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

namespace TheBiggestOf5
{
    class BiggestOfFive
    {
        static void Main()
        {
            //initialize two doubles -
            //one to hold the input value
            //and one to hold the value of the biggest input.(give it the minimal value because that is where we start:)
            double biggest = double.MinValue;
            double input;

            for(int i = 1; i <= 5; i++)
            {
                //int i is going to be the number of inputs needed:
                Console.WriteLine("Enter {0} number:", i);
                input = double.Parse(Console.ReadLine());
                //for every input the whole program will walk through it's cycle
                //if the first input is bigger than the minimal value a double can hold
                //the value of biggest will hold the value of the input.
                //if the second input is bigger than the first, the value of biggest will
                //take it's value, if not - it will still hold the value of input 1.
                if (input > biggest)
                {
                    biggest = input;
                }
            }
            Console.WriteLine("The biggest number is {0}", biggest);

        }
    }
}
