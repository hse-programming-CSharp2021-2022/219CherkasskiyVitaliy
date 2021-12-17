using System;

namespace hw2._2
{
    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor = ConsoleColor.White;
        private ConsoleColor _plateBackColor = ConsoleColor.Black;
        public char _PlateChar
        {
            get => _plateChar;
            set
            {
                if (value.ToString() != value.ToString().ToUpper())
                {
                    _plateChar = 'A';
                }
                else
                {
                    _plateChar = value;
                }
            }
        }

        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor plateBackColor)
        {
            _plateChar = plateChar;
            _plateColor = plateColor;
            _plateBackColor = plateBackColor;
        }
        public ConsolePlate()
        {
            
        }
        public override string ToString()
        {
            Console.ForegroundColor = _plateColor;
            Console.BackgroundColor = _plateBackColor;
            return _plateChar.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate plateElemX = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate plateElemO = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            int N;
            Console.Write("Enter N: ");
            if (int.TryParse(Console.ReadLine(), out N) && N >= 2 && N < 35)
            {
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            Console.Write(plateElemX);
                        }
                        else
                        {
                            Console.Write(plateElemO);
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
