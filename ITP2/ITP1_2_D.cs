using System;

namespace ITP1_2_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i = Console.ReadLine().Split(' ');

            int W = int.Parse(i[0]);
            int H = int.Parse(i[1]);

            int x = int.Parse(i[2]);
            int y = int.Parse(i[3]);
            int r = int.Parse(i[4]);

            if (x + r > H && y + r > W)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
