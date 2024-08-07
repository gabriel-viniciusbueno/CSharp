using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge16
{
    class URI
    {
        static void Main(string[] args)
        {
            int quilometros, minutos;

            quilometros = int.Parse(Console.ReadLine());
            minutos = quilometros * 2;

            Console.WriteLine(minutos + " minutos");
        }
    }
}