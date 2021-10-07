using System;

namespace кроссплатформа 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 1)
            {
                Console.WriteLine("0");
                Console.ReadKey();
            }
            else
            {
                int[] count = new int[1 + n];
                int[] countPlus = new int[1 + n];
                count[0] = 1;
                countPlus[0] = 1;
                for (int i = 2; i <= n; i += 2)
                {
                    count[i] = count[i - 2] + 2 * countPlus[i - 2];
                    countPlus[i] = count[i] + countPlus[i - 2];
                }
                Console.WriteLine($"{count[n]}");
                Console.ReadKey();
            }
        }
    }
}