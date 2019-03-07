using System;
using System.Linq;

class Program
{
  static void Main()
  {
    while(true)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      int h = int.Parse(inputs[0]);
      int w = int.Parse(inputs[1]);
      if (h == 0 && w == 0) break;

      string s1 = string.Concat(Enumerable.Repeat("#.", w / 2));
      string s2 = string.Concat(Enumerable.Repeat(".#", w / 2));

       for (int i = 0; i < h; i ++)
        {
          if (i % 2 == 0)
          {
            if (w % 2 == 0)
            {
              Console.WriteLine(s1);
            }
            else Console.WriteLine(s1 + "#");
          }
          else
          {
            if (w % 2 == 0)
            {
              Console.WriteLine(s2);
            }
            else Console.WriteLine(s2 + ".");
          }
        }
      Console.WriteLine();
    }
  }
}
