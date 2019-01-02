using System;

namespace ITP1_6_C
{
  class Program
  {
    static void Main()
    {
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < 3; i ++)
      {
        string[] x = Console.ReadLine().Split(' ');
        int b = int.Parse(x[0]); //0<b<=4
        int f = int.Parse(x[1]); //0<f<=3
        int r = int.Parse(x[2]); //0<r<=10
        int v = int.Parse(x[3]);
        //b棟f階のr番目の部屋にv人が追加で入居したことを示す。
        for (int j = 0; j < 2; j ++)
        {
          for (int k = 0; k < 10; k ++)
          {
            if (if i = f && j = r)
            {
              Console.Write(" " + v.ToString);
            }
            else
            {
              Console.Write(" 0");
            }
          }
          Console.WriteLine();
          for (int l = 0; l < 20; l ++)
          {
            Console.Write("#");
          }
          Console.WriteLine();
        }
      }
    }
  }
}

//フロア10部屋、3階建ての公舎４棟から入居、退居の情報を読み取り出力するプログラム
