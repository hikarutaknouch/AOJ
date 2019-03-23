using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        LinkedList<string> list = new LinkedList<string>();
        for (int i = 0; i < n; i ++) {
            string[] s = Console.ReadLine().Split();
            switch(s[0]) {
                case "insert":
                    list.AddFirst(s[1]);
                    break;
                case "delete":
                    list.Remove(s[1]);
                    break;
                case "deleteFirst":
                    list.RemoveFirst();
                    break;
                case "deleteLast":
                    list.RemoveLast();
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", list));
    }
}