using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] y = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] xy =new int[n];
        for (int i = 0; i < n; i ++) {
            xy[i] = Math.Max(x[i], y[i]) - Math.Min(x[i], y[i]);
        }
        for (int i = 1; i <= 3; i ++) {
            Console.WriteLine(MinkowskLnegth(xy, i));
        }
    }
    public static void MinkowskLnegth(int[] xy, int p) {
        int sum = 0;
        for (int i = 0; i < xy.Length; i ++) {
            sum += Math.Pow(xy[i],p);
        }
        double d = Math.Sqrt(sum);
        for (int i = 1; i < xy.Length; i ++) {
            d = Math.Sqrt(d);
        }
        return d;
    }
}