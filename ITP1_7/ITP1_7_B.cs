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
      for (int i = 1; i <= x / 3; i ++)
      {
        x -= i;
        for (int j = 1; j <= x / 3; j ++)
        {
          x -= j;
          for (int k = 1; k <= x; k ++)
          {
            x -= k;
            if (x == 0 && (i < j && j < k)) count ++;
            else continue;
          }
        }
      }
      Console.WriteLine(count);
    }
  }
}
