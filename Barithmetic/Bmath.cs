using System;

namespace Barithmetic
{
    internal class Bmath
    {
        static void Main(string[] args)
        {

            double x = 9.99;
            double y = 1.99;
            double z = -55.55;

            double a = Math.Sqrt(x);
            double b = Math.Pow(y, 2);
            double c = Math.Abs(z);
            double d = Math.Round(x);
            double e = Math.Max(x, y);
            double f = Math.Min(y, z);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);






        }
    }
}