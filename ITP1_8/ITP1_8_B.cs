using System;

class ITP1_8_B
{
  static void Main()
  {
    while(true)
    {
      char[] s = Console.ReadLine().ToCharArray();
      if (s[0].ToString() == "0" && s.Length == 1) break;
      int sum = 0;
      for (int i = 0; i < s.Length; i ++)
      {
        sum += int.Parse(s[i].ToString());
      }
      Console.WriteLine(sum);
    }
  }
}
