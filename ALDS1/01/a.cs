using System;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int k = 0; k < a.Length; k ++) {
                if (k==a.Length-1) Console.WriteLine(a[k]);
                else Console.Write(a[k]+" ");
            }
        for (int i = 1; i < n; i ++) {
            int v = a[i];
            int j = i-1;
            while(j>=0 && a[j]>v) {
                a[j+1]=a[j];
                j--;
            }
            a[j+1] = v;
            for (int k = 0; k < a.Length; k ++) {
                if (k==a.Length-1) Console.WriteLine(a[k]);
                else Console.Write(a[k]+" ");
            }
        }
    }
}