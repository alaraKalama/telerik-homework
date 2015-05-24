using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class ParanthesesCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter formula to check for right parantheses:");
            string input = Console.ReadLine();
            

            char currentChar;
            bool correct = false;
            int countParantheses = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    countParantheses++;
                }
                else if (input[i] == ')')
                {
                    countParantheses--;
                }
            }

            if (countParantheses != 0)
            {
                correct = false;
                
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    currentChar = input[i];
                    if (currentChar == '(')
                    {
                        if (!input.Substring(i).Contains(')'))
                        {
                            correct = false;
                        }
                        else
                        {
                            for (int j = i + 3; j < input.Length; j++)
                            {
                                if (input[j] == ')')
                                {
                                    correct = true;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("{0}", correct ? "correct" : "incorrect");

            
        }
    }
}
