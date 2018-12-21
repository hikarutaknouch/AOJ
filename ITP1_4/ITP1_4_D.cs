using System;
using System.Linq;

namespace ITP1_4_D
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            long[] x = Console.ReadLine().Split(' ', '\r', '\n').Select(long.Parse).ToArray();
            Console.WriteLine("{0} {1} {2}", x.Min(), x.Max(), x.Sum());
        }
    }
}
