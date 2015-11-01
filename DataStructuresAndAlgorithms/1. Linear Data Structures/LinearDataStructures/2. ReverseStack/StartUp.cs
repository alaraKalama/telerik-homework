namespace ReverseStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Write a program that reads N integers from the console and reverses them using a stack.
    // Use the Stack<int> class.
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Enter some integers separated by space: ");
            var input = Console.ReadLine();
            var numbers = new Stack<int>();
            var inputArr = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach(var inp in inputArr)
            {
                numbers.Push(int.Parse(inp));
            }
            numbers.Reverse();
            foreach(var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
