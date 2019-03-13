using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        List<int> r = new List<int>();
        r.Add(int.Parse(Console.ReadLine()));
        r.Add(int.Parse(Console.ReadLine()));
        int ans = r[1]-r[0];
        int min = Math.Min(r[0],r[1]);
        for (int i = 2; i < n; i ++) {
            r.Add(int.Parse(Console.ReadLine()));
            int tmp = r[i] - min;
            if(ans < tmp) ans = tmp;
            if(min > r[i]) min = r.Min();
        }
        Console.WriteLine(ans);
    }
}