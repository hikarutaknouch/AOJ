using System;

class ITP1_6_D
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int n = int.Parse(inputs[0]);//行
    int m = int.Parse(inputs[1]);//列
    int[,] A = new int[n, m];
    int[] b = new int[m];
    for (int i = 0; i < n; i ++)
    {
      string[] elementsA = Console.ReadLine().Split(' ');
      for (int j = 0; j < m; j ++)
      {
        A[i, j] = int.Parse(elementsA[j]);
      }
    }
    for (int i = 0; i < m; i ++)
    {
      int elementsB = int.Parse(Console.ReadLine());
      b[i] = elementsB;
    }
    for (int i = 0; i < n; i ++)
    {
      int c = 0;
      for (int j = 0; j < m; j ++)
      {
        c += A[i, j] * b[j];
      }
      Console.WriteLine(c);
    }
  }
}
