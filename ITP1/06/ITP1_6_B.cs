using System;

namespace ITP1_6_B
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            bool [,] y = new bool[4,13];
            //boolでtrueとfalseに分けて、falseの時に出力させる

            string[] s = {"S", "H", "C", "D"};

            for (int i = 0; i < x; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                for (int j = 0; j < 4; j++)
                {
                    if (S[0] == s[j])
                    {
                        int k = int.Parse(S[1]) - 1; //bool型では初期値はfalseになるからあえて1を引く
                        y[j ,k] = true;
                        break;
                    }
                }
            }

            for (int l = 0; l < 4; l ++)
            {
                for (int m = 0; m < 13; m ++)
                {
                    if (y[l, m] == false)
                    {
                        Console.WriteLine(s[l] + " " + (m + 1));
                    }
                }
            }
        }
    }
}
