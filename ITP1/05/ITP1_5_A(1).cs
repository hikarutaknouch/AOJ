using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int h = int.Parse(inputs[0]);
            int w = int.Parse(inputs[1]);

            if (h == 0 && w == 0) break;

            for (int i = 0; i < h; i ++)
            {
                for (int j = 0; j < w; j ++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
