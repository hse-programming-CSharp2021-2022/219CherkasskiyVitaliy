using System;

namespace Task_02
{
    class Program
    {
        static public int MAX(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static public int MIN(int a, int b)
        {
            if (a >= b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            string line;
            int num;

            //---------------//

            do
            {
                Console.Write("Введите трёхзначное число: ");
                line = Console.ReadLine();
            } while(!int.TryParse(line, out num) || num < 100 || num > 999);

            //---------------//

            int a = num % 10;
            num /= 10;
            int b = num % 10;
            num /= 10;
            int c = num;

            //---------------//

            Console.WriteLine($"{MAX(a, MAX(b, c))}{MAX(MIN(a, b), MIN(b, c))}{MIN(a, MIN(b, c))}");
        }
    }
}
