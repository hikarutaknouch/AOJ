using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        double[] s = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double a = s[0];
        double b = s[1];
        double angle = s[2]*(Math.PI / 180);
        double h = b * Math.Sin(angle);
        double c = Math.Sqrt(a*a + b*b - 2*a*b*Math.Cos(angle));
        Console.WriteLine("{0}\n{1}\n{2}", h*a/2, a+b+c, h);
    }
}