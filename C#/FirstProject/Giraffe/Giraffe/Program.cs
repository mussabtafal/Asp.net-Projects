using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string characterName = "George";
             int characterAge = 35;

             Console.WriteLine("There once was a man name " + characterName);
             Console.WriteLine("He was " + characterAge + " years old");

             characterName = "Mike";
             Console.WriteLine("He really liked the name " + characterName);
             Console.WriteLine("But didnt like being " + characterAge);
             Console.ReadLine(); */
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + num2);
            Console.ReadLine();
        }
    }
}
