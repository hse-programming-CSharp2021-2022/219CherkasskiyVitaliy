using System;

namespace Task_01
{
    class Program
    {
        static public double POW(double x, int n)
        {
            double ans = 1;
            for (int i = 1; i <= n; ++i)
            {
                ans *= x;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string line;
            do
            {
                Console.Write("Введите x: ");
                line = Console.ReadLine();
            } while (!double.TryParse(line, out double check));
            double.TryParse(line, out double x);
            Console.WriteLine(12 * POW(x, 4) + 9 * POW(x, 3) - 3 * POW(x, 2) + 2*x - 4);
        }
    }
}
