using System;

namespace hw2._1
{
    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor = ConsoleColor.White;
        public char _PlateChar
        {
            get => _plateChar;
            set 
            { 
                if((int)value <= 31)
                {
                    _plateChar = '+';
                }
                else
                {
                    _plateChar = value;
                }
            }
        }

        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            _plateChar = plateChar;
            _plateColor = plateColor;
        }
        public ConsolePlate()
        {
            _plateChar = '+';
        }
        public override string ToString()
        {
            Console.ForegroundColor = _plateColor;
            return _plateChar.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate[] arrayOfPlates = {new ConsolePlate(), new ConsolePlate('A', ConsoleColor.Green), new ConsolePlate('B', ConsoleColor.Yellow)};
            foreach (var item in arrayOfPlates)
            {
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
    }
}
