using System;

namespace ITP1_4_C
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] x = Console.ReadLine().Split(' ');
                int a = int.Parse(x[0]);
                int b = int.Parse(x[2]);

                if (x[1] == "+")
                {
                    Console.WriteLine(a + b);
                }
                else if (x[1] == "-")
                {
                    Console.WriteLine(a - b);
                }
                else if (x[1] == "*")
                {
                    Console.WriteLine(a * b);
                }
                else if (x[1] == "/")
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
