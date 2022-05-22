using System;

namespace MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Roses are {color}");
            Console.WriteLine("{plural noun} are blue");
            Console.WriteLine("I love {celebrity}");

            Console.ReadLine();

        }
    }
}
