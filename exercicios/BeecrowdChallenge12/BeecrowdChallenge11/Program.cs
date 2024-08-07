using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace challenge12
{
    class URI
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string entrada = Console.ReadLine();
            string[] vet = entrada.Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            triangulo = A * C / 2;
            circulo = 3.14159 * Math.Pow(C, 2);
            trapezio = (A + B) * C / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
