﻿using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge1
{

    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}