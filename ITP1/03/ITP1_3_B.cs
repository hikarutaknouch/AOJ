using System;

namespace ITP1_3_B
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i > 0; i ++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0) break;
                else Console.WriteLine("Case {0}: {1}", i, x);
            }

        }
    }
}
