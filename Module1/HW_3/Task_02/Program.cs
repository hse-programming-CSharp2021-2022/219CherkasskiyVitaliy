using System;

namespace Task_02
{
    class Program
    {
        public static double F(double x, double y)
        {
            if (x < y && x > 0)
            {
                return (x + Math.Sin(y));
            }
            if (x > y && x < 0)
            {
                return (y - Math.Cos(x));
            }
            return (0.5 * x * y);
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(F(x, y));
        }
    }
}
