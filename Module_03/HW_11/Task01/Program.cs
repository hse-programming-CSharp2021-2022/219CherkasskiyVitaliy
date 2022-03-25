using System;
using System.Collections.Generic;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            using (var bw = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; i++)
                {
                    bw.Write(random.Next(1, 101));
                }
            }

            var numbers = new List<int>();

            using (var br = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; i++)
                {
                    numbers.Add(br.ReadInt32());
                    Console.WriteLine(numbers[numbers.Count - 1]);
                }

                int n = int.Parse(Console.ReadLine());
                int min = Math.Abs(n - numbers[0]);
                int res = 0;

                for (int i = 1; i < 10; i++)
                {
                    min = Math.Min(Math.Abs(n - numbers[i]), min);
                    res = i;
                }

                numbers[res] = n;
            }
            using (var bw = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; i++)
                {
                    bw.Write(numbers[i]);
                }
            }
            using (var br = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; i++)
                {
                    numbers[i] = br.ReadInt32();
                }
            }

            numbers.ForEach(x => Console.WriteLine());
        }
    }
}