using System;

namespace Task01
{
    delegate void CoordChanged(Dot dot);
    class Dot
    {
        public double X { get; set; }
        public double Y { get; set; }
        public event CoordChanged OnCoordChanged;
        public Dot(double x, double y)
        {
            X = x; Y = y;
        }
        public void DotFlow()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; ++i)
            {
                X = -10 + rnd.NextDouble() * 15;
                Y = -10 + rnd.NextDouble() * 15;

                if (X < 0 && Y < 0)
                {
                    OnCoordChanged(this);
                }
            }
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dot dot = new Dot(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            dot.DotFlow();
            Console.WriteLine(dot);
        }
    }
}
