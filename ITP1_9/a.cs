using System;

class Program
{
  public static void Main(string[] args)
  {
    string t = Console.ReadLine();
    int count = 0;
    while(true)
    {
      string[] s = Console.ReadLine().Split();
      if (s[0] == "END_OF_TEXT") break;
      for (int i = 0; i < s.Length; i ++)
      {
        s[i] = s[i].ToLower(); //大文字小文字の区別をしないので、小文字に変換しておく。
        if (s[i] == t) count ++;
      }
    }
    Console.WriteLine(count);
  }
}
