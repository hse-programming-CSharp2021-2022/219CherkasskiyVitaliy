using System;

namespace hw2._3
{
    class MyComplex
    {
        private double Re;
        private double Im;
        public MyComplex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public double Mod()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }
        public static MyComplex operator --(MyComplex complexNum)
        {
            complexNum.Re--;
            complexNum.Im--;
            return complexNum;
        }
        public static bool operator true(MyComplex complexNum)
        {
            if (complexNum.Mod() > 1)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator false(MyComplex complexNum)
        {
            if (complexNum.Mod() > 1)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Здесь могла быть ваша реклама.
        }
    }
}
