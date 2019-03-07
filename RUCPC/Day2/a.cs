using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (s.Max() == s[0]) Console.WriteLine("A");
        else if (s.Max() == s[1]) Console.WriteLine("B");
        else Console.WriteLine("C");
    }
}