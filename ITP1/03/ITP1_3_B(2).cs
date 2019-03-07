using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> a = new List<int>();

        while (true)
        {
            string s = Console.ReadLine();
            if (s == "0") break;
            a.Add(int.Parse(s));
        }
        for (int i = 0; i < a.Count; i ++)
        {
            Console.WriteLine("Case {0}: {1}", i + 1, a[i]);
        }
    }
}
