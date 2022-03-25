using System;
using System.Collections.Generic;

namespace Task01
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public string Message { get; set; }
        public RingIsFoundEventArgs(string s) => Message = s;
    }
    public abstract class Creature
    {
        public string Name { get; set; }
        public Creature(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public string Location { get; set; }
        public abstract void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e);
    }
    public class Wizard : Creature
    {
        public Wizard(string name, string location) : base(name, location) { }
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public class Hobbit : Creature
    {
        public Hobbit(string name, string location) : base(name, location)
        {

        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
            Location = e.Message;
        }
    }
    public class Elf : Creature
    {
        public Elf(string name, string location) : base(name, location)
        {

        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Location = e.Message;
        }
    }
    public class Human : Creature
    {
        public Human(string name, string location) : base(name, location)
        {

        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
            Location = e.Message;
        }
    }
    public class Dwarf : Creature
    {
        public Dwarf(string name, string location) : base(name, location) 
        {

        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
            Location = e.Message;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new List<Creature>(10);

            creatures.Add(new Human("Боромир", "Гондор"));
            creatures.Add(new Human("Арагорн", "Горцующий Пони"));
            creatures.Add(new Elf("Леголас", "Лихолесье"));
            creatures.Add(new Dwarf("Гимли", "Эрибор"));
            creatures.Add(new Hobbit("Фродо", "Шир"));
            creatures.Add(new Hobbit("Сэм", "Шир"));
            creatures.Add(new Hobbit("Пипин", "Шир"));
            creatures.Add(new Hobbit("Мэрри", "Шир"));

            var gendalf = new Wizard("Гендальф", "Изенгард");

            foreach (var creature in creatures)
            {
                gendalf.RaiseRingIsFoundEvent += creature.RingIsFoundEventHandlerMethod;
            }
            gendalf.SomeThisIsChangedInTheAir();
        }
    }
}
