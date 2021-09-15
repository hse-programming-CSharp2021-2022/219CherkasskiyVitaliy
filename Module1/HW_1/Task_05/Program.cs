using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            double.TryParse(line1, out double x);
            double.TryParse(line2, out double y);

            double z = x * x + y * y;
            Console.WriteLine(Math.Sqrt(z));
        }
    }
}
