using System;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split().ToArray();
        Console.WriteLine(bubbleSort(s,n));
    }
    static string bubbleSort(int[] s, int n) {
        for (int i = 0; i<n; i ++) {
            for (int j = n-1; j > i+1; j --) {
                if (s[j].Substring(1,1).ToString()<s[j-1].Substring(1,1).ToString()) {
                    string tmp = s[j];
                    s[j-1] = s[j];
                    s[j-1] = tmp;
                }
            }
        }
        return s;
    }
}