using System;

namespace Task_04
{
    class Program
    {
        public static int min(int a, int b)
        {
            if (a % 100 > b % 100)
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
            int room1 = int.Parse(Console.ReadLine());
            int room2 = int.Parse(Console.ReadLine());
            int room3 = int.Parse(Console.ReadLine());

            Console.WriteLine(min(room1, min(room2, room3)));
        }
    }
}
