using System;

namespace ITP1_5_B
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] x = Console.ReadLine().Split(' ');
                int h = int.Parse(x[0]);
                int w = int.Parse(x[1]);

                if (h == 0 && w == 0) break;

                for (int i = 0; i < w; i ++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int j = 0; j < h - 2; j ++)
                {
                    Console.Write("#");
                    for (int k = 0; k < w - 2; k ++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine("#");
                }

                for (int l = 0; l < w-1; l ++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("#");
                Console.WriteLine();
            }
        }
    }
}
