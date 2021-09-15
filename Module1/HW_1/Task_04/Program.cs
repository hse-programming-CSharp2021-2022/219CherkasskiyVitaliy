using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("U = ");string U = Console.ReadLine();
            Console.Write("R = ");string R = Console.ReadLine();

            double.TryParse(U, out double Unum);
            double.TryParse(R, out double Rnum);

            Console.WriteLine($"I = {Unum / Rnum}A");
            Console.WriteLine($"P = {Unum*Unum / Rnum}V*A");
        }
    }
}
