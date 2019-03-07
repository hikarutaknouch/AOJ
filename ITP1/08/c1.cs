using System;

class ITP1_8_C
{
  static void Main()
  {
    int[] results = new int[1200];
    while(true)
    {
      string s = Console.ReadLine();
      if (s == null) break;
      s = s.ToLower();
      for (int i = 0; i < s.Length; i ++)
      {
        results[s[i]] ++;
      }
    }
    for (int i = 'a'; i <= 'z'; i++)
    {
      Console.WriteLine((char)i + " : " + results[i]);
    }
  }
}
