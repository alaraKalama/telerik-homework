﻿namespace CommandPattern.Reciever
{
    using System;

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights are on!");
        }
        public void Off()
        {
            Console.WriteLine("Lights are off");
        }
    }
}