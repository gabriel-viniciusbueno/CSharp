using Microsoft.VisualBasic;
using System;
using System.Globalization;


namespace challenge20
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, dias, anos, meses, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }
    }
}