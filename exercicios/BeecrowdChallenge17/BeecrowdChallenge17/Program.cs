using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge17
{
    class URI
    {
        static void Main(string[] args)
        {
            double horas, quilometros, combustivel;

            horas = double.Parse(Console.ReadLine());
            quilometros = double.Parse(Console.ReadLine());

            combustivel = quilometros * horas / 12;

            Console.WriteLine(combustivel.ToString("F3"));
        }
    }
}