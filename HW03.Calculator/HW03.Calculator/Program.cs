using System;

namespace HW03.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear User! Welcome to my Calculator!");
            Console.WriteLine("Let's practice addition.");
            Console.WriteLine("Please input a number:");
            string num1Txt = Console.ReadLine();
            Console.WriteLine("Please input a number:");
            string num2Txt = Console.ReadLine();
            int number1 = Convert.ToInt32(num1Txt);
            int number2 = Convert.ToInt32(num1Txt);
            Console.WriteLine(number1 + number2);
            Console.WriteLine("Great result!!!");

            Console.WriteLine("Let's practice subtraction.");
            Console.WriteLine("Please input a number:");
            string num3Txt = Console.ReadLine();
            Console.WriteLine("Please input a number:");
            string num4Txt = Console.ReadLine();
            int number3 = Convert.ToInt32(num3Txt);
            int number4 = Convert.ToInt32(num4Txt);
            Console.WriteLine(number3 - number4);
            Console.WriteLine("You are like a star!!!");

            Console.WriteLine("Let's practice multiplication.");
            Console.WriteLine("Please input a number:");
            string num5Txt = Console.ReadLine();
            Console.WriteLine("Please input a number:");
            string num6Txt = Console.ReadLine();
            int number5 = Convert.ToInt32(num5Txt);
            int number6 = Convert.ToInt32(num6Txt);
            Console.WriteLine(number5 * number6);
            Console.WriteLine("Perfect!!!");

            Console.WriteLine("Let's practice division.");
            Console.WriteLine("Please input a number:");
            string num7Txt = Console.ReadLine();
            Console.WriteLine("Please input a number:");
            string num8Txt = Console.ReadLine();
            int number7 = int.Parse(num7Txt);
            int number8 = int.Parse(num8Txt);
            Console.WriteLine(number7 / number8);
            Console.WriteLine("Amazing!!!");

            Console.WriteLine("Let's practice division by module.");
            Console.WriteLine("Please input a number:");
            string num9Txt = Console.ReadLine();
            Console.WriteLine("Please input a number:");
            string num10Txt = Console.ReadLine();
            double number9 = double.Parse(num9Txt);
            double number10 = double.Parse(num10Txt);
            Console.WriteLine(number7 % number8);
            Console.WriteLine("You are almost done!");

            Console.WriteLine("Let's do the last exercise.");
            Console.WriteLine("Please input a number:");
            string num11Txt = Console.ReadLine();
            double number11 = double.Parse(num11Txt);
            double number12 = 3.1416;
            Console.WriteLine(number11 * number12);
            Console.WriteLine("You are the winner!");
        }
    }
}
