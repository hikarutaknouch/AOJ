using System;
using System.Linq;

//間違いコード
class Program
{
  static void Main()
  {
    char[] s = Console.ReadLine().ToCharArray();
    for (int i = 0; ; i ++)
    {
      char[] s1 = Console.ReadLine().ToCharArray();
      s1.CopyTo(s, s.Length);
      if (s.Length > 1200) break;
    }

    char[] alpha = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

    for (int i = 0; i < 26; i ++)
    {
      int count = 0;
      for (int j = 0; j < s.Length; j ++)
      {
        if (s[j] == alpha[i] || s[j] == char.ToUpper(alpha[i])) count ++;
      }
      Console.WriteLine("{0} : {1}", alpha[i].ToString(), count);
    }
  }
}
