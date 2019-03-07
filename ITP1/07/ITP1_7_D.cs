using System;

class ITP1_7_D
{
  static void Main()
  {
    string[] s = Console.ReadLine().Split(' ');
    long n = long.Parse(s[0]);
    long m = long.Parse(s[1]);
    long l = long.Parse(s[2]);
    long[,] A = new long[n, m];
    long[,] B = new long[m, l];
    long[,] C = new long[n, l];
    for (int i = 0; i < n; i ++)
    {
      string[] input = Console.ReadLine().Split(' ');
      for (long j = 0; j < m; j ++) A[i, j] = long.Parse(input[j]);
    }
    for (long i = 0; i < m; i ++)
    {
      string[] input = Console.ReadLine().Split(' ');
      for (long j = 0; j < l; j ++) B[i, j] = long.Parse(input[j]);
    }
    for (long i = 0; i < n; i ++)
    {
      for (long j = 0; j < l; j ++)
      {
        for (long k = 0; k < m; k ++) C[i, j] += A[i, k] * B[k, j];
        if (j != l - 1) Console.Write(C[i, j] + " ");
        else Console.Write(C[i, j]);
      }
      Console.WriteLine();
    }
  }
}
