using System;

namespace Task_01
{
    class Program
    {
        static public bool Shift(ref char ch)
        {
            if (((int)ch > 90 || (int)ch < 65) && ((int)ch < 97 || (int)ch > 112)) 
            {
                return false;
            }
            else
            {
                ch = (char)((int)(ch) + 4);
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            string line = Console.ReadLine();

            if (char.TryParse(line, out char  ch) && Shift(ref ch))
            {
                Console.WriteLine($"Новый символ это: {ch}");
            }
            else
            {
                Console.WriteLine("Это не символ!");
            }
        }
    }
}
