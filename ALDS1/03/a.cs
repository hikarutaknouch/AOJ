using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        string[] str = Console.ReadLine().Split().ToArray();
        Stack<int> s = new Stack<int>();
        for (int i = 0; i < str.Length; i ++) {
            if (str[i]=="+") s.Push(s.Pop() + s.Pop());
            else if (str[i]=="-") s.Push((s.Pop() - s.Pop()) * -1);
            else if (str[i]=="*") s.Push(s.Pop() * s.Pop());
            else s.Push(int.Parse(str[i]));
        }
        Console.WriteLine(s.Pop());
    }
}