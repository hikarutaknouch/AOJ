using System;

class Program
{
  public static void Main(string[] args)
  {
    while (true)
    {
      string s = Console.ReadLine();
      if (s == "-") break;
      int m = int.Parse(Console.ReadLine());
      for (int i = 0; i < m; i ++) {
        int h = int.Parse(Console.ReadLine());
        string s1 = s.Substring(0, h);//0~h番目までの文字列を取得。
        string s2 = s.Substring(h);//h番目から最後までの文字列を取得。
        s = s2 + s1;
      }
      Console.WriteLine(s);
    }
  }
}
