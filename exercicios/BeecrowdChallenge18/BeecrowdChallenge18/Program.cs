using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge18
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, notasDeCem, notasDeCinq, notasDeVinte, notasDeDez, notasDeCinco, notasDeDois, notasDeUm;
            N = int.Parse(Console.ReadLine());

            notasDeCem = Math.Abs(N / 100);
            N = N - notasDeCem * 100;
            notasDeCinq = Math.Abs(N / 50);
            N = N - notasDeCinq * 50;
            notasDeVinte = Math.Abs(N / 20);
            N = N - notasDeVinte * 20;
            notasDeDez = Math.Abs(N / 10);
            N = N - notasDeDez * 10;
            notasDeCinco = Math.Abs(N / 5);
            N = N - notasDeCinco * 5;
            notasDeDois = Math.Abs(N / 2);
            N = N - notasDeDois * 2;
            notasDeUm = Math.Abs(N / 1);

            Console.WriteLine(notasDeCem + "nota (s) de R$ 100,00");
            Console.WriteLine(notasDeCinq + "nota (s) de R$ 50,00");
            Console.WriteLine(notasDeVinte + "nota (s) de R$ 20,00");
            Console.WriteLine(notasDeDez + "nota (s) de R$ 10,00");
            Console.WriteLine(notasDeCinco + "nota (s) de R$ 5,00");
            Console.WriteLine(notasDeDois + "nota (s) de R$ 2,00");
            Console.WriteLine(notasDeUm + "nota (s) de R$ 1,00");
        }
    }
}