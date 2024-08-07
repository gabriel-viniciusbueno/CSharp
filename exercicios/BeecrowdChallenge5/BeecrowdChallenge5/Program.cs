using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge5
{
    class URI
    {

        static void Main(string[] args)
        {

            double A, APonderado, B, BPonderado, MEDIA;


            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            APonderado = A * 3.5;
            BPonderado = B * 7.5;
            MEDIA = (APonderado + BPonderado) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

        }

    }
}
