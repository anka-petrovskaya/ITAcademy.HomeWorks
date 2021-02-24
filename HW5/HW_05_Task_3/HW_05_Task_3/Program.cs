using System;

namespace HW_05_Task_3
{
    class Program
    {
        static void Main()
        {
            Greeting greetiing = new Greeting();
            greetiing.Main();
        }
    }
    public class Greeting
    {
        public void Main()
        {
            Console.WriteLine(value: DateTime.Now.TimeOfDay);
            int hour = DateTime.Now.Hour;

            switch(hour)
            {
                case 9:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 10:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 11:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 12:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 13:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 14:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 15:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 16:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 17:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 18:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 19:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 20:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 21:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 22:
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Good night!");
                    break;
            }
        }
    }
}
