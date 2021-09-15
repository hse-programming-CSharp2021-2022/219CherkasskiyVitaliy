using System;

namespace Task_03
{
    class Program
    {
        public static double FIND_DIS(double a, double b, double c)
        {
            return (Math.Pow(b, 2) - 4 * a * c);
        }
        public static void FIND_X(double a, double b, double c)
        {
            bool check_dis = FIND_DIS(a, b, c) >= 0 ? true : false;
            while(!check_dis)
            {
                Console.WriteLine("Корней нет.");
                return;
            }
            double x1 = (-b + Math.Sqrt(FIND_DIS(a, b, c))) / (2 * a);
            double x2 = (-b - Math.Sqrt(FIND_DIS(a, b, c))) / (2 * a);
            while(x1 == x2)
            {
                Console.WriteLine($"Единственный корень уравнения: {x1}");
                return;
            }
            Console.WriteLine($"Корни уравнения: {x1} , {x2}");
        }
        static void Main(string[] args)
        {
            string line1, line2, line3;
            double a, b, c;

            do
            {
                Console.Write("Введите коэффициент при x^2: ");
                line1 = Console.ReadLine();
                Console.Write("Введите коэффициент при x: ");
                line2 = Console.ReadLine();
                Console.Write("Введите свободный коэффициент: ");
                line3 = Console.ReadLine();
            } while (!double.TryParse(line1, out a) || !double.TryParse(line2, out b) || !double.TryParse(line3, out c));

            FIND_X(a, b, c);
        }
    }
}
