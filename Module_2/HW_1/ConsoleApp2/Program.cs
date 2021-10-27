using System;

public partial class Task_1
{
    class RegularPolygon
    {
        int amountOfSides { get; set; }
        double circleRadius { get; set; }
        public RegularPolygon(int x = 0, double y = 0)
        {
            amountOfSides = x;
            circleRadius = y;
        }
        public double Perimeter()
        {
            return 2 * circleRadius * Math.Tan(Math.PI / 2 / amountOfSides);
        }
        public double Square()
        {
            return amountOfSides * Math.Pow(circleRadius, 2) * Math.Tan(Math.PI / 2 / amountOfSides);
        }
        public string PolygonData()
        {
            return $"Perimetr is equal to: {this.Perimeter()}\n" +
                   $"Square is equal to: {this.Square()}"; 
        }
    }
    public static void Main()
    {
        Console.Write("Enter amount of objects: ");
        int amountOfObjects = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("-----------");
        Console.WriteLine();
        RegularPolygon[] objects = new RegularPolygon[amountOfObjects];
        int tempAmount;
        double tempRadius;
        for (int i = 0; i < objects.Length; ++i)
        {
            Console.Write($"Enter amount of sides for {i+1} object: ");
            tempAmount = int.Parse(Console.ReadLine());
            Console.Write($"Enter radius of inner circle for {i+1} object: ");
            tempRadius = int.Parse(Console.ReadLine());
            // Initialize values.
            objects[i] = new RegularPolygon(tempAmount, tempRadius);
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
        }
        double minPerimetr = objects[0].Perimeter(), maxPerimetr = objects[0].Perimeter(), 
               minSquare = objects[0].Square(), maxSquare = objects[0].Square();
        for (int i = 0; i < objects.Length; ++i)
        {
            // Get max & min values.
            if (i > 0)
            {
                if (minPerimetr > objects[i].Perimeter())
                {
                    minPerimetr = objects[i].Perimeter();
                }
                if (maxPerimetr < objects[i].Perimeter())
                {
                    maxPerimetr = objects[i].Perimeter();
                }
                if (minSquare > objects[i].Square())
                {
                    minSquare = objects[i].Square();
                }
                if (maxSquare < objects[i].Square())
                {
                    maxSquare = objects[i].Square();
                }
            }
        }
        Console.Write("Minimal perimetr is equal to ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(minPerimetr);
        Console.WriteLine();
        //------------------------------------------//
        Console.ResetColor();
        Console.Write("Minimal square is equal to ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(minSquare);
        Console.WriteLine();
        //------------------------------------------//
        Console.ResetColor();
        Console.Write("Maximal perimetr is equal to ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(maxPerimetr);
        Console.WriteLine();
        //------------------------------------------//
        Console.ResetColor();
        Console.Write("Maximal square is equal to ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(maxSquare);
        Console.ResetColor();
    }
}