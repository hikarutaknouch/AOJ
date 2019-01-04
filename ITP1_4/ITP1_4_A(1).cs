using System;

class Program
{
    static void Main()
    {
        string[] i = Console.ReadLine().Split(' ');
        int a = int.Parse(i[0]);
        int b = int.Parse(i[1]);

        decimal x = decimal.Parse(i[0]);
        decimal y = decimal.Parse(i[1]);

        int d = a / b;
        int r = a % b;
        decimal f = x / y;

        Console.WriteLine("{0} {1} {2}", d, r, f);
    }
}
