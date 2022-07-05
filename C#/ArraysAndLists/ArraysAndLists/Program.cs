using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Console.WriteLine("Length: " + numbers.Length);

            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("index of 9 is: " + index);

            //Array.Clear(numbers, 0, 2);

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //int[] another = new int[3];

            //Array.Copy(numbers, another, 3);

            //Array.Sort(numbers);
            //foreach (var number in numbers )
            //    Console.WriteLine(number);

            //Array.Reverse(numbers);
            //foreach ( var number in numbers )
            //    Console.WriteLine(number);


            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            //foreach (var number in numbers)
            //Console.WriteLine(number);

            //Console.WriteLine(numbers.IndexOf(1));
            //Console.WriteLine(numbers.LastIndexOf(1));
            //Console.WriteLine(numbers.Count);

            //numbers.Remove(1);
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            numbers.Clear();
            Console.WriteLine(numbers.Count);
        }
    }
}
