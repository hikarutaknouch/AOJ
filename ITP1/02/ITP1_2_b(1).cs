using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var a = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();

        if (a[0] < a[1] && a[1] < a[2])
        {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
    }
}
