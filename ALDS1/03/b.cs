using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = s[0];
        int q = s[1];
        Queue<string> que1 = new Queue<string>();
        Queue<int> que2 = new Queue<int>();
        for (int i = 0; i<n; i ++) {
            string[] str = Console.ReadLine().Split().ToArray();
            que1.Enqueue(str[0]);
            que2.Enqueue(int.Parse(str[1]));
        }
        int time = 0;
        while(que2.Count != 0) {
            if (que2.Peek()-q > 0) {
                time += q;
                que1.Enqueue(que1.Dequeue());
                que2.Enqueue(que2.Dequeue()-q);
            }
            else {
                time += que2.Dequeue();
                Console.WriteLine(que1.Dequeue() + " " + time);
            }
        }
    }
}