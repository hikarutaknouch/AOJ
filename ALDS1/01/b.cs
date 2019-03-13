using System;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = s[0];
        int y = s[1];
        Console.WriteLine(gcd(x,y));
    }
    static int gcd(int x, int y) {
        if (x<y) return gcd(y,x);
        while(x%y>0) {
            int temp = y;
            y = x%y;
            x = temp;
        }
        return y;
    }
}