using System;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dateTime = new DateTime(2022, 1, 1);
            //Console.WriteLine(dateTime);
            //var now = DateTime.Now;
            //Console.WriteLine(now);
            //var today = DateTime.Today;
            //Console.WriteLine(today);

            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.Hour);

            //var tomorrow = now.AddDays(1);
            //Console.WriteLine(tomorrow);

            //var yesterday = now.AddDays(-1);
            //Console.WriteLine(yesterday);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine(timeSpan1);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan2); 

                    var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration: " + duration);


            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.TotalMinutes);

            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine(timeSpan.ToString());

            Console.WriteLine(TimeSpan.Parse("01:02:03"));



        }
    }
}
