using System;
using System.Linq;

class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i ++) {
            int X = int.Parse(Console.ReadLine());
            if (PrimeNumber(X) == true) count ++;
        }
        Console.WriteLine(count);
    }
    static bool PrimeNumber(int x) {
        for (int i = 2; i <= Math.Sqrt(x); i ++) {
            if (x%i==0) return false;
        }
        return true;;
    }
}