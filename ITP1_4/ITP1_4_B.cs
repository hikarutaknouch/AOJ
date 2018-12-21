using System;

namespace ITP1_4_B
{
    class Program
    {
        static void Main()
        {
            var r = double.Parse(Console.ReadLine());

            //円の面積=半径×半径×円周率
            //円周の長さ=直径×円周率
            double f = 3.141592653589;

            double s = r * r * f;
            double p = 2 * r * f;

            Console.WriteLine("{0} {1}", s, p);
        }
    }
}
