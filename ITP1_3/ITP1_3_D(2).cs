using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(Enumerable.Range(x[0], x[1] - x[0] + 1).Count(q => x[2] % q == 0));
    }
}
