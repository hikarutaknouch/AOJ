using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        List<int> s = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        n = s.Count();
        int q = int.Parse(Console.ReadLine());
        List<int> t = Console.ReadLine().Split().Select(int.Parse).ToList();
        s.Sort();
        int count = 0;
        for (int i = 0; i < q; i ++) {
            count += binarySearch(s,n,t[i]);
        }
        Console.WriteLine(count);
    }
    static int binarySearch(List<int> s, int n, int t) {
        int l = 0;
        int r = n;
        while(l < r) {
            int m = (l+r)/2;
            if (s[m]<t) l = m+1;
            else if (s[m]>t) r = m;
            else return 1;
        }
        return 0;
    }
}