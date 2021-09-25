using System;

namespace Task_6._01
{
    class Program
    {
        static public void Compression(ref int[] arr, out int n)
        {
            n = 0;

            for (int i = 0; i < arr.Length - 1 - n; ++i)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] *= arr[i + 1];
                    n += 1;

                    for (int k = i + 1; k < arr.Length - 1; ++k)
                    {
                        arr[k] = arr[k + 1];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Compression(ref arr, out n);
            for (int i = 0; i < arr.Length - n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
