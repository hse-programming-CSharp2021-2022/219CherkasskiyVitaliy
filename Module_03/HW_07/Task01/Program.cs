using System;
using System.Collections.Generic;

namespace Task01
{
    struct Person : IComparable<Person>
    {
        string _name;
        string _lastname;
        int _age;

        public int Age => _age;
        public string Name => _name;
        public string Lastname => _lastname;
        public Person(string name, string lastname, int age)
        {
            if (name.Length == 0 || lastname.Length == 0 || age <= 0)
            {
                throw new ArgumentException("Incorrect input");
            }

            _name = name;
            _lastname = lastname;
            _age = age;
        }

        public int CompareTo(Person other)
        {
            if (Age < other.Age)
            {
                return -1;
            }
            return 1;
        }
        public override string ToString()
        {
            return $"{Name} {Lastname}, age = {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var characters = new List<Person>();
            var rnd = new Random();

            for (int i = 0; i < n; ++i)
            {
                string name = "";
                string lastName = "";

                for (int j = 0; j < rnd.Next(0,8); ++j)
                {
                    name += (char)rnd.Next('a', 'z');
                }
                for (int j = 0; j < rnd.Next(0, 8); ++j)
                {
                    lastName += (char)rnd.Next('a', 'z');
                }

                try
                {
                    characters.Add(new Person(name, lastName, rnd.Next(-5, 90)));
                }
                catch (ArgumentException e)
                {
                    --i;
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            characters.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--sorted below--");
            characters.Sort();
            characters.ForEach(x => Console.WriteLine());
        }
    }
}
