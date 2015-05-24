//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

namespace GravitationOnTheMoon
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kg:");
            double kg = double.Parse(Console.ReadLine());
            double kgMoon = 0.17;
            Console.WriteLine("On the moon you will be {0}kg.", kg*kgMoon);
            
        }
    }
}
