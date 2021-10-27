using System;
using System.Linq;

public partial class Task_2
{
    class Point
    {
        double X { get; set; }
        double Y { get; set; }
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public double R
        {
            get
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
        }
        double F
        {
            get
            {
                if (X > 0 && Y >= 0)
                {
                    return (Math.Atan(Y / X));
                }
                if (X > 0 && Y < 0)
                {
                    return (Math.Atan(Y / X) + Math.PI * 2);
                }
                if (X < 0)
                {
                    return (Math.Atan(Y / X) + Math.PI);
                }
                if (X == 0 && Y > 0)
                {
                    return (Math.PI / 2);
                }
                if (X == 0 && Y < 0)
                {
                    return (Math.PI * 3 / 2);
                }
                return 0;
            }
        }
        public void PrintData()
        {
            Console.WriteLine($"Декартовы координаты --> X = {X} ; Y = {Y}");
            Console.WriteLine($"Полярные координаты  --> R = {R} ; F = {F}");
        }
    }
    public static void Main()
    {
        Random rand = new Random();
        Point point1, point2, point3;
        double x, y;
        // ------------------------------ //
        while (true)
        {
            point1 = new Point(rand.Next(-100, 100), rand.Next(-100, 100));
            point2 = new Point(rand.Next(-100, 100), rand.Next(-100, 100));
            Console.Write("Введите значение координаты Х для третьей точки: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение координаты Y для третьей точки: ");
            y = double.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                break;
            }
            point3 = new Point(x, y);
            Console.WriteLine("------------");

            Point[] listOfPoints = { point1, point2, point3 };
            var sortedList = from value in listOfPoints
                             orderby (value.R)
                             select value;
            foreach (var item in sortedList)
            {
                item.PrintData();
                Console.WriteLine();
            }
            Console.WriteLine("------------");
        }
        // ------------------------------ //
        Console.WriteLine("Конец :)");
    }
}