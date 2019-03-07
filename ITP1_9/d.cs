using System;
using System.Linq;

class Program
{
    public static void Main(string[] args) {
        char[] str = Console.ReadLine().ToCharArray();
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i ++) {
            string[] s = Console.ReadLine().Split().ToArray();
            int a = int.Parse(s[1]);
            int b = int.Parse(s[2]);
            if (s[0] == "print") {
                string S = new String(str);
                Console.WriteLine(S.Substring(a, b-a+1));
            }
            if (s[0] == "reverse") {
                while(a<b) {
                    Swap(ref str[a], ref str[b]);
                    a++;
                    b--;
                }
            }
            if (s[0] == "replace") {
                char[] y = s[3].ToCharArray();
                int k = 0;
                for (int j = a; j <= b; j ++) {
                    str[j] = y[k];
                    k ++;
                }
            }
        }
    }
    public static void Swap<T>(ref T a, ref T b) {
        var t = a;
        a = b;
        b = t;
    }
}