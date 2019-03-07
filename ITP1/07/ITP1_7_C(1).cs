using System;

class ITP1_7_C
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int r = int.Parse(s[0]);
        int c = int.Parse(s[1]);

        int[,] sheet = new int[r + 1, c + 1];

        for (int i = 0; i < r; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < c; j++)
            {
                sheet[i, j] = int.Parse(input[j]);
                sheet[i, c] += sheet[i, j];
                sheet[r, j] += sheet[i, j];
                sheet[r, c] += sheet[i, j];
            }
        }

        for (int i = 0; i < r + 1; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(sheet[i, j] + " ");
            }
            Console.WriteLine(sheet[i, c]);
        }
    }
}
