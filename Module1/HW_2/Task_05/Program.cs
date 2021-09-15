using System;

namespace Task_05
{
    class Program
    {
        static public bool trng(double a, double b, double c)
        {
            return (a < (b + c)) ? true : false;
        }
        static void Main(string[] args)
        {
            string line1, line2, line3;
            double a, b, c;
            do
            {
                Console.WriteLine("Введите 3 стороны треугольника через ENTER: ");
                line1 = Console.ReadLine();
                line2 = Console.ReadLine();
                line3 = Console.ReadLine();
            } while (!double.TryParse(line1, out a) | !double.TryParse(line2, out b) | !double.TryParse(line3, out c));

            
            Console.WriteLine(trng(a,b,c) && trng(b,c,a) && trng(c,b,a));
        }
    }
}
