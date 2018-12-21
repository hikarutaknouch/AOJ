using System;

namespace ITP1_5_A
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] x = Console.ReadLine().Split(' ');
                int h = int.Parse(x[0]);
                int w = int.Parse(x[1]);
                if (h == 0 && w == 0) break;

                for (int j = 0; j < h; j ++)
                {
                    for (int i = 0; i < w; i ++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
