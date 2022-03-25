using System;
using System.Collections;
namespace Task01
{
    class Fibbonacci : IEnumerable
    {
        int f0 = 1, f1 = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
        public IEnumerable NameEnumerator(int n)
        {
            int f0 = 1, f1 = 1;
            for (int i = 0; i < n; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
    }
    class TriangleNums : IEnumerable
    {
        int num = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return num;
                num += (i + 2);
            }
        }
        public IEnumerable NameEnumerator(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                yield return num;
                num += (i + 2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new Fibbonacci();
            var triangleNums = new TriangleNums();
            var array = new int[10];

            var counter = 0;
            foreach (object el in fibonacci.NameEnumerator(10))
            {
                Console.WriteLine(el);
                array[counter] = (int)el;
                ++counter;
            }
            counter = 0;
            foreach (object el in triangleNums.NameEnumerator(10))
            {
                Console.WriteLine(el);
                array[counter] += (int)el;
                ++counter;
            }
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }
        }
    }
}
