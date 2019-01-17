using System;

class ITP1_7_B
{
  static void Main()
  {
    while (true)
    {
      string[] inputs =  Console.ReadLine().Split(' ');
      int n = int.Parse(inputs[0]);
      int x = int.Parse(inputs[1]);
      if (n == 0 && x == 0) break;

      int count = 0;
      for (int i = 1; i <= n; i ++)
      {
        for (int j = 1; j <= n; j ++)
        {
          for (int k = 1; k <= n; k ++)
          {
            if (i + j + k == x && i < j && j < k) count ++;
          }
        }
      }
      Console.WriteLine(count);
    }
  }
}
