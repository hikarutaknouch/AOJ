using System;

namespace ITP1_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int x = i * i * i; //べき乗計算はMathクラス（System名前空間）の静的メソッドであるPowメソッドを使う。ex.double result = Math.Pow(2, 3); resultは8
            //C#には^演算子はあるが、排他的論理和を求める演算子になる。(例えば2^3は1となる。)
            Console.WriteLine(x);
        }
    }
}
