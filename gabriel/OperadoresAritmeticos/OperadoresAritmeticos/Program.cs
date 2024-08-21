using System;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = -3.0, c = -4.0;
            double delta = (Math.Pow(b, 2.0) - 4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"X1: {x1} X2: {x2}");



        }
    }
}
