using System;

namespace Triangle
{
    internal class Program
    {
        static string GetTriangleType(double a, double b, double c)
        {
            if (a != b && a != c && b != c)
            {
                return "обычный";
            }
            else if (a == b && b == c)
            {
                return "равносторонний";
            }
            else if (a < 0 || b < 0 || c < 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return "не треугольник";
            }

            return "равнобедренный";
        }

        const string error = "неизвестная ошибка";

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                try
                {
                    double a = double.Parse(args[0]);
                    double b = double.Parse(args[1]);
                    double c = double.Parse(args[2]);

                    if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
                    {
                        Console.WriteLine(error);
                    }
                    else
                    {
                        string triangleType = GetTriangleType(a, b, c);
                        Console.WriteLine(triangleType);
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine(error);
            }
        }
    }
}
