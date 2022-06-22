using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            checked
            {
                byte number = 255;
                number = (byte)(number + 1);
                Console.WriteLine(number);
            }
           
        }
    }
}
