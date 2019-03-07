using System;

class ITP1_7_C
{
  static void Main()
  {
    string[] s = Console.ReadLine().Split(' ');
    int r = int.Parse(s[0]);
    int c = int.Parse(s[1]);
    int[,] A = new int[r + 1, c + 1];

    for (int i = 0; i < r; i ++)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      for (int j = 0; j < c; j ++)
      {
        A[i, j] = int.Parse(inputs[j]);
        A[i, c] += A[i,j];
      }
    }
    for (int i = 0; i < r; i ++)
    {
      for (int j = 0; j <= c; j ++)
      {
        A[r, j] += A[i,j];
      }
    }
    for (int i = 0; i <= r; i ++)
    {
      for (int j = 0; j <= c; j ++)
      {
        if(j != 0) Console.Write(' ');
        Console.Write(A[i,j]);
      }
      Console.WriteLine();
    }
  }
}
