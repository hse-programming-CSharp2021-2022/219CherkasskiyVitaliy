using System;

namespace Task_03
{
    class Program
    {
        static public int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static public int Min(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static public void FindNok(int a, int b, out int nok)
        {
            for (int i = Max(a, b) * 2; true; ++i)
            {
                if (i % a == 0 && i % b == 0)
                {
                    nok = i;
                    break;
                }
            }
        }
        static public void FindNod(int a, int b, out int nod)
        {
            for (int i = (int)(Min(a, b)/2) + 1; true; --i)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    nod = i;
                    break;
                }
            }
        }
        static public void FindNokNod(int a, int b, out int nod, out int nok)
        {
            FindNod(a, b, out nod);
            FindNok(a, b, out nok);
        }
        static void Main(string[] args)
        {
            int nok, nod;

            FindNokNod(14, 65, out nod, out nok);

            Console.WriteLine(nod + " " + nok);
        }
    }
}
