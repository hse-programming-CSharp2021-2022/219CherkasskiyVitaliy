using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task01
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }

        public Human() { }

        public Human(string name)
        {
            Name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }

        public Professor() { }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    public class Department
    {
        public Department() { }

        public string Name { get; set; }
        public List<Human> people { get; set; }

        public Department(List<Human> people, string name)
        {
            Name = name;
            people = people.ToList();
        }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    [XmlInclude(typeof(Department))]
    public class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public University() { }

        public University(List<Department> departments, string name)
        {
            Name = name;
            Departments = departments;
        }
    }

    class Program
    {
        static async Task Main()
        {
            var people = new List<Human>();
            people.Add(new Human("human1"));
            people.Add(new Human("human2"));
            people.Add(new Human("human3"));
            people.Add(new Human("human4"));
            people.Add(new Human("human5"));
            people.Add(new Professor("professor1"));
            people.Add(new Professor("professor2"));
            people.Add(new Professor("professor3"));

            var departments = new List<Department>();
            departments.Add(new Department(people, "dep1"));
            departments.Add(new Department(people, "dep2"));

            var unis = new List<University>()
            {
                new University(departments, "u1"),
                new University(departments, "u2")
            };

            using (var fs = new FileStream("JSON.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, unis);
                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("JSON.json", FileMode.OpenOrCreate))
            {
                var g = await JsonSerializer.DeserializeAsync<List<University>>(fs);
                Console.WriteLine("Объект десериализован");
            }

            using (var fs = new FileStream("XML.xml", FileMode.OpenOrCreate))
            {
                var formatter = new XmlSerializer(typeof(List<University>));
                formatter.Serialize(fs, unis);
                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("XML.xml", FileMode.OpenOrCreate))
            {
                var formatter = new XmlSerializer(typeof(List<University>));
                var newGroup = (List<University>)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
            }

            using (var fs = new FileStream("BinaryFormatter.dat", FileMode.OpenOrCreate))
            {
                var formater = new BinaryFormatter();
                formater.Serialize(fs, unis);
                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("BinaryFormatter.dat", FileMode.OpenOrCreate))
            {
                var formater = new BinaryFormatter();
                var newUni = (List<University>)formater.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
            }
        }
    }
}