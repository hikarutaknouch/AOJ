using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        while(true) {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;
            int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double m = s.Average();
            double sum = 0;
            for (int i = 0; i < n; i ++) {
                sum += Math.Pow(s[i] - m, 2);
            }
            Console.WriteLine(Math.Sqrt(sum/n));
        }
    }
}