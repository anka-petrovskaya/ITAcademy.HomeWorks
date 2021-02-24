using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1;
            Console.WriteLine("Please enter the symbol W, S, A or D");
            string symbol1Txt = Console.ReadLine();
            symbol1 = Convert.ToChar(symbol1Txt);

            if (symbol1 == 'W')
            {
                Console.WriteLine("Move your player to the top of the page");
            }
            if (symbol1 == 'S')
            {
                Console.WriteLine("Move your player to the bottom of the page");
            }
            if (symbol1 == 'A')
            {
                Console.WriteLine("Move your player right");
            }
            if (symbol1 == 'D')
            {
                Console.WriteLine("Move your player left");
            }
            else
            {
                Console.WriteLine("your symbol is incorrect! Please enter the correct symbol!");
            }
        }
    }
}
