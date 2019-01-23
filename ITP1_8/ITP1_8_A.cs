using System;

class ITP1_8_A
{
  static void Main()
  {
    char[] s = Console.ReadLine().ToCharArray();
    for (int i = 0; i < s.Length; i ++)
    {
      if (char.IsUpper(s[i])) s[i] = char.ToLower(s[i]);
      else s[i] = char.ToUpper(s[i]);
    }
    Console.WriteLine(s);
  }
}
