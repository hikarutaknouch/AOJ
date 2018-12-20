using System;

namespace ITP1_3_D
{
    class Program
    {
        static void Main()
        {
            string[] x = Console.ReadLine().Split(' ');

            var a = int.Parse(x[0]);
            var b = int.Parse(x[1]);
            var c = int.Parse(x[2]);

            var count = 0;

            for (int i = a; i <= b; i++)
                if (c % i == 0) count++;
            Console.WriteLine(count);
        }
    }
}
