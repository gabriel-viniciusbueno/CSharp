using Microsoft.VisualBasic;
using System;
using System.Globalization;


namespace challenge4
{
    class URI
    {

        static void Main(string[] args)
        {
            float A, B, PROD;

            A = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());
            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }

    }

}
