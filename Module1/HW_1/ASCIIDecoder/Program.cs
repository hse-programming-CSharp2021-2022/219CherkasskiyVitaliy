using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int.TryParse(line, out int code);

            char symbol = (char)code;
            Console.WriteLine(symbol);
        }
    }
}
