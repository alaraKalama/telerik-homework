using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
//the rest of the characters should be filled with *.
//Print the result string into the console.
namespace StringLength
{
    class StringLenghtMax20
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int strLenght = inputStr.Length;
            string output = string.Empty;

            if (strLenght > 20)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                if (strLenght < 20)
                {
                    int difference = 20 - strLenght;
                    string appendix = new string('*', difference);
                    output = inputStr + appendix;
                }
                else if (strLenght == 20)
                {
                    output = inputStr;
                }
            }

            Console.WriteLine(output);
        }

    }
}
