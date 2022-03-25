using System;

namespace Task01
{
    interface IFunction
    {
        double Function(double x);
    }
    delegate double Calculate(double x);
    class F : IFunction
    {
        public Calculate Calc { get; set; }
        public double Function(double x)
        {
            return Calc(x);
        }
        public F(Calculate calc)
        {
            Calc = calc;
        }
    }
    class G
    {
        F f;
        F g;
        public G(F f, F g)
        {
            this.f = f;
            this.g = g;
        }
        public double GF(double x)
        {
            return g.Function(f.Function(x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate a = (double x) => (x * x - 4);
            Calculate b = (double x) => (Math.Sin(x));
            G g = new G(new F(a), new F(b));
            for(double i = 0; i < Math.PI + 1e-9; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):F4}");
            }
        }
    }
}
