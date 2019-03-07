using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        long[] s = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long a = s[0];
        long b = s[1];
        long x = s[2];
        long t = a-b;
        long count = 0;
        while(true) {
            if (x <= a) {
                count += x%b;
                break;
            }
            x -= t;
            count += a;
            if (x <= a) {
                count += a+b;
                break;
            }
        }
        Console.WriteLine(count%1000000007);
    }
}