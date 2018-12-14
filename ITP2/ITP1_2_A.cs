using System;

namespace ITP1_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                Console.WriteLine("a == b");
            }
        }
    }
}
