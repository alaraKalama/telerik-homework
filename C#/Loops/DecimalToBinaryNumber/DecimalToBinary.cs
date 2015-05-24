﻿/*
 * Using loops write a program that converts 
 * an integer number to its binary representation. 
 * The input is entered as long. 
 * The output should be a variable of type string. 
 * Do not use the built-in .NET functionality.
 */

using System;
using System.Text;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number in decimal:");
        long dec = long.Parse(Console.ReadLine());
        long tempDec = dec;
        long remainder;
        StringBuilder binary = new StringBuilder();

        while (tempDec > 0)
        {
            int index = 0;
            remainder = tempDec % 2;
            binary.Insert(index, remainder);

            tempDec /= 2;
            index++;
        }
        Console.WriteLine("The binary representation of {0} is {1}", dec, binary);
    }
}