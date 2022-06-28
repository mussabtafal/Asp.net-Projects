using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 55;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("Ir's afternoon");
            //else
            //    Console.WriteLine("It's evening.");

            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);

            //var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //    case Season.Summer:
            //        Console.WriteLine("Test");
            //        break;
            //    default:
            //        Console.WriteLine("Test 3");
            //        break;
            //}

            //Application excercise 1

            //Console.Write("Please enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number <= 10 && number >= 0)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("InValid");

            //Application excercise 2

            //Console.Write("Please enter the first number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the second number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 > number2)
            //    Console.WriteLine(number1);
            //else 
            //    Console.WriteLine(number2);

            //Application excercise 3

            //Console.Write("Please the height of the picture: ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the width of the picture: ");
            //int width = Convert.ToInt32(Console.ReadLine());

            //if (height > width)
            //    Console.WriteLine("portrait");
            //else
            //    Console.WriteLine("Landscape");

            //Application excercise 4

            Console.WriteLine("Please enter speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please ennter the car speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            } else
            {
                int demeritPoints = carSpeed/5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended !");
                }

            }

            


        }
    }
}
