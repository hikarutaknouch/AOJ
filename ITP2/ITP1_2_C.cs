using System;
using System.Linq;

namespace ITP1_2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(x);
            Console.WriteLine(x[0] + " " + x[1] + " " + x[2]);
        }
    }
}
