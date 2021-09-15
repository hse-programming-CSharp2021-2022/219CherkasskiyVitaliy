using System;

namespace Task_07
{
    class Program
    {
        static public void int_float(double num)
        {
            Console.WriteLine($"/-----------/");
            Console.WriteLine($"Целая часть числа равна: {(int)num}");
            Console.WriteLine($"Дробная часть числа равна: {num - (int)num}");
        }
        static public void sqrt_pow(double num)
        {
            Console.WriteLine($"/-----------/");
            Console.WriteLine($"Корень числа равен: {Math.Sqrt(num)}");
            Console.WriteLine($"Квадрат числа равен: {Math.Pow(num, 2)}");
        }
        static void Main(string[] args)
        {
            string line;
            double check;

            do
            {
                Console.Write("Введите число: ");
                line = Console.ReadLine();
            } while (!double.TryParse(line, out check));

            int_float(check);
            sqrt_pow(check);
        }
    }
}
