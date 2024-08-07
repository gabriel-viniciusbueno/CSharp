using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge9
{
    class URI
    {

        static void Main(string[] args)
        {
            string name;
            double salary, sales, payment;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine());
            sales = double.Parse(Console.ReadLine());

            payment = salary + sales * 0.15;

            Console.WriteLine("TOTAL = R$ " + payment.ToString("F2"));
        }
    }
}
