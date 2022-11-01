using System;

namespace Triangle
{
    public class Program
    {
        private static string GetTriangleType(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a || a < 0 || b < 0 || c < 0)
            {
                return "не треугольник";
            }
            else if (a != b && a != c && b != c)
            {
                return "обычный";
            }
            else if (a == b && b == c)
            {
                return "равносторонний";
            }
            else
            {
                return "равнобедренный";
            }
        }

        const string error = "неизвестная ошибка";

        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 3)
                {
                    throw new Exception();
                }

                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);
                double c = double.Parse(args[2]);
                
                if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
                {
                    throw new Exception();
                }

                string triangleType = GetTriangleType(a, b, c);
                Console.Write(triangleType);
            }
            catch (Exception)
            {
                Console.Write(error);
            }
        }
    }
}
