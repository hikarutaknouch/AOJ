using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        List<int> s = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        int q = int.Parse(Console.ReadLine());
        int[] t = Console.ReadLine().Split().Select(int.Parse).ToArray();
        n = s.Count();
        int count = 0;
        for(int i = 0; i < q; i ++) {
            s.Add(t[i]);
            count += linearSearch(s,n);
            s.RemoveAt(n);
        }
        Console.WriteLine(count);
    }
    static int linearSearch(List<int> s,int n) {
        int i = 0;
        int key = s[n];
        while(s[i] != key) {
            i ++;
            if (i == n) {
                return 0;
            }
        }
        return 1;
    }
}