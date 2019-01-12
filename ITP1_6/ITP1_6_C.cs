using System;

namespace ITP1_6_C
{
  class Program
  {
    static void Main()
    {
      int n = int.Parse(Console.ReadLine());
      int[, ,] A = new int[4, 3, 10];
      for (int i = 0; i < n; i ++)
      {
        string[] inputs = Console.ReadLine().Split(' ');
        int b = int.Parse(inputs[0]); //0<b<=4
        int f = int.Parse(inputs[1]); //0<f<=3
        int r = int.Parse(inputs[2]); //0<r<=10
        int v = int.Parse(inputs[3]);
        //b棟f階のr番目の部屋にv人が追加で入居したことを示す。
        A[b - 1, f - 1, r - 1] = v;
      }
      for (int i = 0; i < 4; i ++)
      {
        for (int j = 0; j < 3; j ++)
        {
          for (int k = 0; k < 10; k ++)
          {
            if (A[i, j, k] == null) A[i, j, k] = 0;
            Console.Write(" {0}", A[i, j, k]);
          }
          Console.WriteLine();
        }
        string text = new String('#', 20);
        if (i != 3) Console.WriteLine(text);
      }
    }
  }
}

//フロア10部屋、3階建ての公舎４棟から入居、退居の情報を読み取り出力するプログラム
