using System;

namespace ITP1_1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            int h = S / 3600;
            int m = S % 3600 / 60;
            int s = S % 60;
            Console.WriteLine("{0}:{1}:{2}", h, m, s);
        }
    }
}
