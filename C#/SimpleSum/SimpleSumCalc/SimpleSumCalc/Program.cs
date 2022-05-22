using System;

namespace SimpleSumCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
    }
}
