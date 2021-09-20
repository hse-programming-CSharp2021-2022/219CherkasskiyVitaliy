using System;

namespace Task_03
{
    class Program
    {
        public static double F(double x)
        {
            if (x <= 0.5)
            {
                return (Math.Sin(Math.PI / 2));
            }
            else
            {
                return (Math.Sin(Math.PI * (x - 1) / 2));
            }
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine(F(x));
        }
    }
}
