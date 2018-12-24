using System;

namespace ITP1_5_D
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 3; i <= x; i ++)
            {
                if (i % 3 == 0 || i % 10 == 3 || i % 100 / 10 == 3 || i % 1000 / 100 == 3 || i % 10000 / 1000 == 3)
                {
                    Console.Write(" " + i);
                }
                else continue;
            }
            Console.WriteLine();
        }
    }
}
