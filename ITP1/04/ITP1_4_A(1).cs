using System;

class Program
{
    static void Main()
    {
        string[] i = Console.ReadLine().Split(' ');
        int a = int.Parse(i[0]);
        int b = int.Parse(i[1]);

        int d = a / b;
        int r = a % b;
        double f = (double)a / b;

        Console.WriteLine("{0} {1} {2}", d, r, f.ToString("f5"));
    }
}
