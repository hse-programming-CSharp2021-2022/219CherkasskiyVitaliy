using System;
using System.Collections.Generic;


namespace Task01
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point B)
        {
            return Math.Sqrt((B.X - X) * (B.X - X) + (B.Y - Y) * (B.Y - Y));
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    class Circle: IComparable<Circle>
    {
        Point O;
        double rad;
        public Circle(double x, double y, double r)
        {
            this.O = new Point(x, y);
            rad = r;
        }
        public override string ToString()
        {
            return $"радиус: {rad}, центр: {O}";
        }

        public int CompareTo(Circle other)
        {
            if (this < other)
                return 1;
            return 1;
        }

        public static bool operator >(Circle W1, Circle W2)
        {
            return W1.O.Distance(new Point()) * W1.rad > W2.O.Distance(new Point()) * W2.rad;
        }
        public static bool operator <(Circle W1, Circle W2)
        {
            return W1.O.Distance(new Point()) * W1.rad < W2.O.Distance(new Point()) * W2.rad;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var circles1 = new List<Circle>();
            var circles2 = new List<Circle>();

            for (int i = 0; i < 10; ++i)
            {
                circles1.Add(new Circle(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10)));
                circles2.Add(new Circle(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10)));
            }

            circles1.Sort();
            circles2.Sort();

            circles1.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            circles2.ForEach(x => Console.WriteLine(x));
        }
    }
}
