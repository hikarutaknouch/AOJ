using System;

class Program
{
  public static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    int taro = 0;
    int hanako = 0;
    for (int i = 0; i < n; i ++)
    {
      string[] s = Console.ReadLine().Split(' ');
      string s1 = s[0];
      string s2 = s[1];
      int compare = string.Compare(s1, s2);
      if (compare == 0)
      {
        taro ++;
        hanako ++;
      }
      else if (compare > 0 ) taro += 3;
      else hanako += 3;
    }
    Console.WriteLine("{0} {1}", taro, hanako);
  }
}
