using System;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = 0;
        for (int i = 0; i < n; i ++) {
            int min = i;
            for (int j = i; j < n; j ++) {
                if(s[j]<s[min]) min = j;
            }
            if (min != i) count ++;
            int tmp = s[i];
            s[i] = s[min];
            s[min] = tmp;
        }
        for (int i = 0; i < n; i ++) {
            if (i == n-1) Console.WriteLine(s[i]);
            else Console.Write(s[i]+" ");
        }
        Console.WriteLine(count);
    }
}