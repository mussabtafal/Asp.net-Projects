using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Arithmatic Operators
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b); 
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);

        //Comparison Operators
            var d = 1;
            var e = 2;

            Console.WriteLine(d == e);
            Console.WriteLine(d != e);
            Console.WriteLine(!(d != e));

        //Comparison Operators
            var f = 1;
            var h = 2;
            var g = 3;

            Console.WriteLine(g > h && g > f);
            Console.WriteLine(g > h && g == f);
            Console.WriteLine(g > h || g== f);
            Console.WriteLine(!(g > h || g == f));




        }
    }
}
