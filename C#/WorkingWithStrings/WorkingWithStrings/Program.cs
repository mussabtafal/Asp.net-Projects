using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var word = "Potato";
            //Console.WriteLine(word.IndexOf('a')) ;
            //Console.WriteLine(word.LastIndexOf('t'));
            //Console.WriteLine(word.Substring(3));
            //Console.WriteLine(word.Substring(3, 1));
            //Console.WriteLine(word.Replace('P', 't'));

            //var fullName = "Mussab Taffal ";
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);
            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);

            //var names = fullName.Split(' ');
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);


            //Console.WriteLine(fullName.Replace("Mussab", "Moose"));

            //if (String.IsNullOrEmpty(fullName))
            //    Console.WriteLine("Invalid");

            //var str = "25";
            //var age = Convert.ToByte(str);
            //Console.WriteLine(age);

            //float price = 29.95f;
            //Console.WriteLine(price.ToString("C4"));


            //var sentence = "this is going to be a really really really really really long text";
            //var summary = StringUtility.SummarizeText(sentence, 25);

            //Console.WriteLine(summary);

            //var builder = new StringBuilder("Hello World");
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);
            //builder.Replace('-', '+');
            //builder.Remove(0, 10);
            //builder.Insert(0, new string('-', 10));
            //Console.WriteLine(builder);

            //Console.WriteLine(builder[0]);

            Console.Write("What's your name ?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
         
            Console.WriteLine(reversed);
        }

        public static string ReverseName (string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
            
        }
    }
}
