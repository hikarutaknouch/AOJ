using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        double[] s = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double x = Math.Sqrt(Math.Pow(s[2]-s[0], 2)+ Math.Pow(s[3]-s[1],2));
        Console.WriteLine(x);
    }
}