using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge8
{
    class URI
    {
        static void Main(string[] args)
        {
            int A, B;
            double C, salary;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            salary = B * C;

            Console.WriteLine("NUMBER " + A);
            Console.WriteLine("SALARY = $ " + salary.ToString("F2"));
        }

    }
}
