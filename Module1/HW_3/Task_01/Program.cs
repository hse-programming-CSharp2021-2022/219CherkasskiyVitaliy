using System;

namespace Task_01
{
    class Program
    {
        static public bool F(double x, double y)
        {
            if (x*x + y*y <= 4)
            {
                if (!(x > 0 && y < 0) && !(x > 0 && y > 0 && y < x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(F(x, y));
        }
    }
}
