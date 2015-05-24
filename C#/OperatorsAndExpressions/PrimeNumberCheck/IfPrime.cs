//Write an expression that checks if given positive integer number n (n <= 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
using System;

namespace PrimeNumberCheck
{
    class PrimeNumbers
    {
        static void Main()
        {
            //First we have to read a number given by the user and convert it to uint.
            Console.WriteLine("Enter a real number to check if it's prime:");
            uint n = uint.Parse(Console.ReadLine());
            //A prime number is dividable only by 1 and itself, so we create a divider 
            //to later devide the input number to all the numbers between 2 and the input number.
            uint divider = 2;
            //Actually you can be sure a number is prime if it can't be devided by it's own sqare root.
            uint maxDivider = (uint) Math.Sqrt(n);
            //To check if prime or not we also need a bool with initial value true.
            bool isPrime = true;

            //While loop will execute everything within it's {}block while the statement in () is true.
            while (divider <= maxDivider)
            {
                //So while divider is less than maxDivider we will try to divide the input by every number between them.
                if (n % divider == 0)
                {
                    //If you get result 0, that mean the input is not prime.
                    isPrime = false;
                }
                //If not you start dividing by the next number:
                divider++;
            }
            //And print the results:
            Console.WriteLine("{0} {1} prime.", n, isPrime? "is":"isn't");
        }

    }
}
