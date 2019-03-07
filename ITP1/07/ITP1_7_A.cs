using System;

class ITP1_7_A
{
  static void Main()
  {
    while (true)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      int m = int.Parse(inputs[0]);
      int f = int.Parse(inputs[1]);
      int r = int.Parse(inputs[2]);

      if (m == -1 && f == -1 && r == -1) break;
      if (m == -1 || f == -1)
      {
        Console.WriteLine("F");
        continue;
      }

      int sum = m + f;
      if (sum >= 80) Console.WriteLine("A");
      else if (sum >= 65 && sum < 80) Console.WriteLine("B");
      else if (sum >= 50 && sum < 65) Console.WriteLine("C");
      else if (sum >= 30 && sum < 50)
      {
        if (r >= 50) Console.WriteLine("C");
        else Console.WriteLine("D");
      }
      else Console.WriteLine("F");
    }
  }
}
