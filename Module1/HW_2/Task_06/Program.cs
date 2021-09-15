using System;

namespace Task_06
{
    class Program
    {
        static public decimal converting(decimal sum)
        {
            return (sum / (decimal)72.67);
        }
        static void Main(string[] args)
        {
            string line1, line2;
            decimal money;
            int percents;

            do
            {
                Console.Write("Введите общий бюджет: ");
                line1 = Console.ReadLine();
                Console.Write("Введите процент бюджета, выделенного под видеоигры: ");
                line2 = Console.ReadLine();
            } while (!decimal.TryParse(line1, out money) | !int.TryParse(line2, out percents));

            Console.WriteLine($"{money}RUB/72,67 * {percents}/100 = {converting(money) * percents / 100}$");
        }
    }
}
