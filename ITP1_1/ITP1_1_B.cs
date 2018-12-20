using System;

namespace ITP1_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int x = i * i * i;
            //C#には^演算子はあるが、排他的論理和を求める演算子になる。(例えば2^3は1となる。)
            Console.WriteLine(x);
        }
    }
}
