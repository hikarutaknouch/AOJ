using System;

class ITP1_8_D
{
  /// <summary>
  ///   文字列sの任意の位置からスタートして一周する間に文字列pが作れるかどうか判定する。
  /// </summary>
  [STAThread]
  public static void Main(string[] args)
  {
    string s = Console.ReadLine();
    string p = Console.ReadLine();
    string ss = s + s;///文字列sを重ねれば、仮に文字列sの最後と最初で文字列pが形成されるとしても対応できる。
    if (ss.Contains(p)) Console.WriteLine("Yes");
    else Console.WriteLine("No");
  }
}
