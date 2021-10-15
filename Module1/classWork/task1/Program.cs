using System;
using System.Linq;
using System.Collections.Generic;

namespace Classwork
{
    class Program
    {
        public static int[] RandomArray(int n)
        {
            var rand = new Random();
            int[] returnArray = new int[n];
            for (int i = 0; i < n; ++i)
            {
                returnArray[i] = rand.Next(1, 10000);
            }
            return returnArray;
        }
        public static bool IsPalindrom(int num)
        {
            bool flag = true;
            for (int i = 0; i < num.ToString().Length; ++i)
            {
                if (num.ToString()[0 + i] != num.ToString()[num.ToString().Length - 1 - i])
                {
                    flag = false;
                }
            }
            return flag;
        }
        public static int GetSum(int x)
        {
            int sum = 0;
            for (int temp = x; temp > 0; temp /= 10)
            {
                sum += temp % 10;
            }
            return sum;
        }
        public static void WriteArray(int[] array)
        {
            foreach(int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            // Ввести n, сгенировать массив чисел от 1 до 10000.
            // 1) Запрос, который вернет двухначные числа кратные 3
            // 2) Запрос, который вернет в порядке возрастания
            // все палиндромы (читается одинако)
            // 3) Запрос, который отсортирует числа по сумме цифр, а затем по
            // значению числа
            // 4) Запрос, который найдет сумму всех четырехзнчных чисел
            // 5) Запрос, который найдет минимальное значение среди всех двузначных
            // чисел
            // 6) запрос, который формирует коллекцию

            int n = int.Parse(Console.ReadLine());
            int[] array = RandomArray(n);

            //1
            WriteArray(array);
            var selected1 = from item in array
                            where (item.ToString().Length == 2 && item % 3 == 0)
                            select item;

            Console.Write("1. ");
            foreach (var item in selected1)
                Console.Write(item + " ");
            Console.WriteLine();

            //2
            var selected2 = from item in array
                            where (IsPalindrom(item))
                            orderby item
                            select item;

            Console.Write("2. ");
            foreach (var item in selected2)
                Console.Write(item + " ");
            Console.WriteLine();

            //3
            var selected3 = array.OrderBy(x => GetSum(x)).ThenBy(x => x);

            Console.Write("3. ");
            foreach (var item in selected3)
                Console.Write(item + " ");
            Console.WriteLine();

            //4
            int sum = 0;
            var selected4 = from item in array
                            where (item.ToString().Length == 4)
                            select item;

            Console.Write("4. ");
            foreach (var value in selected4)
                sum += value;
            Console.Write(sum);
            Console.WriteLine();

            //5
            int min = 999999;
            var selected5 = from item in array
                             where (item.ToString().Length == 2)
                             orderby (item)
                             select item;

            Console.Write("5. ");
            foreach (var item in selected5)
            {
                Console.Write(item);
                break;
            }
            Console.WriteLine();

            //6
            List<int> answer6 = new List<int>();
            var selected6 = from item in array
                            select item;
            foreach (var item in selected6)
            {
                answer6.Add(item);
            }
            Console.Write("6. ");
            foreach (int item in answer6)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}