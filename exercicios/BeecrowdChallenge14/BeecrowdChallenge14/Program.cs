// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace challenge14
{
    class URI
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3") + " km/l");
        }
    }
}