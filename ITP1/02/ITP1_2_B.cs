using System;

namespace ITP1_2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split();
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            int c = int.Parse(x[2]);

            if (a < b && b < c)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
