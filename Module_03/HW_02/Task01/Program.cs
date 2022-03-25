using System;

namespace Task01
{
    class Plant : IComparable
    {
        double _growth;
        int _photosensitivity;
        int _frostresistance;
        public double Growth => _growth;
        public int Photosensitivity => _photosensitivity;
        public int Frostresistance => _frostresistance;


        public Plant(double growth, int photosensitivity, int frostresistance)
        {
            _growth = growth;
            _photosensitivity = photosensitivity;
            _frostresistance = frostresistance;
        }
        public override string ToString()
        {
            return $"рост: {_growth}, светочувствительность: {_photosensitivity}, морозоустойчивость: {_frostresistance}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Plant)
            {
                var plant = obj as Plant;
                if (plant.Growth < plant.Growth)
                {
                    return 1;
                }
                return -1;
            }

            throw new ArgumentException("Not a plant");
        }
    }
    class Program
    {
        public static int comparer1(Plant a, Plant b)
        {
            if (a.Photosensitivity % 2 == 0 && b.Photosensitivity % 2 != 0)
            {
                return -1;
            }
            return 1;
        }
        public static int comparer2(Plant a, Plant b)
        {
            if (a.Frostresistance < b.Frostresistance)
            {
                return -1;
            }
            return 1;
        }
        public static int comparer3(Plant a, Plant b)
        {
            if (a.Growth < b.Growth)
            {
                return -1;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Plant[] plants = new Plant[n];
            Random rnd = new Random();

            for(int i = 0; i < n; ++i)
            {
                plants[i] = new Plant(rnd.NextDouble() * 50, rnd.Next(0, 100), rnd.Next(0, 100));
            }

            Console.WriteLine("------");
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("------");

            Array.Sort(plants, comparer3);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("------");

            Array.Sort(plants, comparer2);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("------");

            Array.Sort(plants, comparer1);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("------");
        }
    }
}
