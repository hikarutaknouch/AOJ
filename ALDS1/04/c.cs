using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> list = new HashSet<string>();
        for (int i = 0; i < n; i ++) {
            string[] s = Console.ReadLine().Split().ToArray();
            if(s[0]=="insert") list.Add(s[1]);
            else Console.WriteLine(list.Contains(s[1]) ? "yes" : "no");
        }
    }
}