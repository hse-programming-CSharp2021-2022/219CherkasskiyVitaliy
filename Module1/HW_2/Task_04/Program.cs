using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int check, ans = 0;

            //___//

            do
            {
                Console.Write("Введите 4-хзначное число: ");
                line = Console.ReadLine();
            } while (!int.TryParse(line, out check) || check > 9999 || check < 1000);

            //__//

            for (int i = 1; i <= 4; ++i)
            {
                ans += (check % 10)*(int)(Math.Pow(10, 4 - i));
                check /= 10;
            }

            //__//

            Console.WriteLine(ans);
        }
    }
}
