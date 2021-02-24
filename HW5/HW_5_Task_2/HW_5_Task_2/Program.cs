using System;

namespace HW_5_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter the number");
            string numberTxt = Console.ReadLine();
            number = Convert.ToInt32(numberTxt);

            int number1 = 1;

            for (int i = number; i != 0; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(number1 + " ");
                }
                Console.WriteLine(number1);
                Console.Write(new String(' ', number - i + 1));
                if (++number1 == 10) number1 = 0;
            }
        }
    }
}
