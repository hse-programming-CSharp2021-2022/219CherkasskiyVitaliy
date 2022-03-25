using System;

namespace Task01
{
    class Program
    {
        delegate int Cast(double a);
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double a)
            {
                if ((int)a % 2 == 0)
                {
                    return (int)a;
                }

                return (int)a + 1;
            };

            Cast cast2 = delegate (double a)
            {
                return ((int)a).ToString().Length;
            };

            Console.WriteLine(cast1(12312.6));
            Console.WriteLine(cast2(38848.888));
        }
    }
}
