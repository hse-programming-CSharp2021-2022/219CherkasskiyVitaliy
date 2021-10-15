using System;
using System.Text.RegularExpressions;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            //1
            Regex regex1 = new Regex(@"\b[а-яА-Я]{4}\b");
            MatchCollection match1 = regex1.Matches(line);

            Console.Write("1. ");
            foreach (Match text in match1)
            {
                Console.Write(text + " ");
            }
            Console.WriteLine();

            //2
            Regex regex2 = new Regex(@"\b[а-яА-Я]+а\b");

            MatchCollection match2 = regex2.Matches(line);

            Console.Write("2. ");
            foreach (Match text in match2)
            {
                Console.Write(text + " ");
            }
            Console.WriteLine();

            //3
            Regex regex3 = new Regex(@"\d+");

            MatchCollection match3 = regex3.Matches(line);

            Console.Write("3. ");
            int max = 0;
            foreach (Match text in match3)
            {
                if (text.Length > max)
                {
                    max = text.Length;
                }
            }
            Console.Write(max);
        }
    }
}
