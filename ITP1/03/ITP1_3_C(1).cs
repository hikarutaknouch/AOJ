using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] a = Console.ReadLine().Split(' ');
            int x = int.Parse(a[0]);
            int y = int.Parse(a[1]);

            if (x == 0 && y == 0) break;
            else if (x <= y) Console.WriteLine("{0} {1}", x, y);
            else Console.WriteLine("{0} {1}", y, x);
        }
    }
}
