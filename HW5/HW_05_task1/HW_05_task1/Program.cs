using System;

namespace HW_05_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number more then 0");
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            if (number <= 0)
            {
                Console.WriteLine("Please enter the correct number more then 0");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    result += i;
                }
                Console.WriteLine(result);
            }

        }
    }
}
