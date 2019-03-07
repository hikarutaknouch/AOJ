using System;

namespace ITP1_6_A
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string[] x = Console.ReadLine().Split(' ');

            for (int i = n - 1; i >= 0; i --)
            {
                var j = int.Parse(x[i]);
                if (i == 0) Console.Write(j);
                else Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
