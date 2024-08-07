using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge15
{
    class URI
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;
            string valoresP1 = Console.ReadLine();
            string valoresP2 = Console.ReadLine();

            string[] valorP1 = valoresP1.Split(' ');
            string[] valorP2 = valoresP2.Split(' ');

            x1 = double.Parse(valorP1[0]);
            y1 = double.Parse(valorP1[1]);
            x2 = double.Parse(valorP2[0]);
            y2 = double.Parse(valorP2[1]);

            distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
