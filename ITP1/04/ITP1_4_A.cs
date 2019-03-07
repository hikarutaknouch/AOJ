using System;

namespace ITP1_4_A
{
    class Program
    {
        static void Main()
        {
            string[] x = Console.ReadLine().Split(' ');
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);

            int d = a / b;
            int r = a % b;

            decimal f = (decimal)a / (decimal)b;

            Console.WriteLine("{0} {1} {2}", d, r, f);
        }
    }
}
