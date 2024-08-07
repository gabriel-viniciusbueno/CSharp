using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge19
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, segundos, minutos, horas;

            N = int.Parse(Console.ReadLine());
            // segundos = N / 60;
            segundos = N % 60;
            minutos = (N / 60) % 60;
            horas = (N / 60) / 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}