using System;
namespace ITP1_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            //String.SplitメソッドとはStringクラスメソッドの一つで、文字列を指定した区切り文字で分割し配列に格納する場合に使う

            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);

            Console.WriteLine(a * b + " " + (a + b) * 2);
        }
    }
}
