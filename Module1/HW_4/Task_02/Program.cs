using System;

namespace Task_02
{
    class Program
    {
        static public int Factorial(int value)
        {
            int ans = 1;

            for (int i = 1; i <= value; ++i)
            {
                ans *= i;
            }

            return ans;
        }
        static public double Sum1(double x, int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; ++i)
            {
                if (i % 2 == 0)
                {
                    sum -= (Math.Pow(x, 2 * i) * Math.Pow(2, 2 * i - 1)) / Factorial(2 * i);
                }
                else
                {
                    sum += (Math.Pow(x, 2 * i) * Math.Pow(2, 2 * i - 1)) / Factorial(2 * i);
                }
            }

            return sum;
        }
        static public double Sum2(double x, int n)
        {
            double sum = 0;

            for (int i = 0; i <= n; ++i)
            {
                sum += Math.Pow(x, i) / Factorial(i);
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string line1, line2;

            Console.Write("Введите x: ");
            line1 = Console.ReadLine();

            Console.Write("Введите количество членов прогрессии: ");
            line2 = Console.ReadLine();

            if (double.TryParse(line1, out double x) && int.TryParse(line2, out int n))
            {
                Console.WriteLine($"Сумма {n} членов первой прогрессии равна {Sum1(x, n)}");
                Console.WriteLine($"Сумма {n} членов второй прогрессии равна {Sum2(x, n)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных.");
            }
        }
    }
}
