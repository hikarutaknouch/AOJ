using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        List<long> inputs = Console.ReadLine().Split(' ').Select(t => long.Parse(t)).ToList();
        long max = inputs.Max();
        long min = inputs.Min();
        long sum = inputs.Sum();
        Console.WriteLine("{0} {1} {2}", min, max, sum);
    }
}
