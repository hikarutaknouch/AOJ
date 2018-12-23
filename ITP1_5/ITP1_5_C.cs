using System;

namespace ITP1_5_C
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

                for (int i = 0; i < h; i ++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        //(奇数行かつ奇数列)または(偶数行かつ偶数列)の場合、行番号i+列番号j=偶数
                        //(奇数行かつ偶数列)または(偶数行かつ奇数列)の場合、行番号i+列番号j=奇数
                        if ((i + j) % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
