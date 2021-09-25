using System;

namespace Task_6._02
{
    class Program

    {
        static public void Compression(ref int[] arr, out int n)
        {
            n = 0;

            for (int i = 0; i < arr.Length - n; ++i)
            {
                if (arr[i] % 2 == 0)
                {
                    ++n;
                    --i;

                    for (int k = i + 1; k < arr.Length - 1; ++k)
                    {
                        arr[k] = arr[k + 1];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int n, amount = int.Parse(Console.ReadLine());
            int[] arr = new int[amount];
            
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(-10, 10); 
            }
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Compression(ref arr, out n);
            Console.WriteLine("");
            for (int i = 0; i < arr.Length - n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
