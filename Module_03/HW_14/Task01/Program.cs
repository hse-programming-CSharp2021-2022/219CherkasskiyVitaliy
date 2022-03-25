using System;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            Random random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1001);
            }
            foreach (var el in array)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();

            var newArray = array.Select(x => x * x).ToArray();
            Array.ForEach(newArray, Console.WriteLine);
            Console.WriteLine("==========");

            newArray = array.Where(x => x > 0 && x < 100).ToArray();
            Array.ForEach(newArray, Console.WriteLine);
            Console.WriteLine("==========");

            newArray = array.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            Array.ForEach(newArray, Console.WriteLine);
            Console.WriteLine("==========");

            var newArray2 = array.GroupBy(x => x.ToString().Length).ToArray();
            Array.ForEach(newArray2, x =>
            {
                Array.ForEach(x.ToArray(), Console.WriteLine);
            });
        }
    }
}