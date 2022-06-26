using NonPrimitiveDataTypes.Math;
using System;

namespace NonPrimitiveDataTypes
{
    //Enums
    public enum ShippingMethod
    {
        RegularAirMail =1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person()    
            {
                FirstName = "John",
                LastName = "Smith"
            };
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            //Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            var names = new string[3] {"Jack", "John", "Marry"};
            Console.WriteLine(names);
            string name = "Mussab";


            //Enums

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);


        }
    }
}
