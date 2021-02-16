using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4;

            Console.WriteLine("Enter number 1");
            string num1Txt = Console.ReadLine();
            number1 = Convert.ToInt32(num1Txt);

            Console.WriteLine("Enter number 2");
            string num2Txt = Console.ReadLine();
            number2 = Convert.ToInt32(num2Txt);

            Console.WriteLine("Enter the result:" ,number1 - number2);
            string num3Txt = Console.ReadLine();
            number3 = int.Parse(num3Txt);

            number4 = number1 - number2;

            if (number4 == number3)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
    }
}
