using System;

namespace Task02
{
    delegate double NewDelegate(double x);
    class TemperatureConventerImp
    {
        public double Celcium2Faringate(double x)
        {
            return ((double)5 / 9) * (x - 32);
        }
        public double Faringate2Celcium (double x)
        {
            return ((double)9 / 5) * x + 32;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            NewDelegate delegate1 = new NewDelegate(new TemperatureConventerImp().Celcium2Faringate);
            delegate1 += new TemperatureConventerImp().Faringate2Celcium;
            Console.WriteLine(delegate1(18));
        }
    }
}
