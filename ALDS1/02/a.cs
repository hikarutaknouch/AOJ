using System;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool flag = true;
        int count = 0;
        while(flag) {
            flag = false;
            for (int i = n-1; i > 0; i --) {
                if (a[i]<a[i-1]) {
                    int tmp = a[i];
                    a[i] = a[i-1];
                    a[i-1] = tmp;
                    count ++;
                    flag = true;
                }
            }
        }
        for (int i = 0; i < n; i ++) {
            if (i == n-1) Console.WriteLine(a[i]);
            else Console.Write(a[i]+" ");
        }
        Console.WriteLine(count);
    }
}