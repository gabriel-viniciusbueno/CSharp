using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double raioQuadrado = Math.Pow(raio, 2);
            double area = raioQuadrado * pi;
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}