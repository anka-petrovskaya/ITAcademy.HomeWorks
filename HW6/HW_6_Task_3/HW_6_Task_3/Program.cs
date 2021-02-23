using System;

namespace HW_6_Task_3
{
    class Program
    {
        //option 1
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10, k;
            int[] nums = new int[size];
            Console.WriteLine("Массив случайных чисел!");

            for (k = 0; k < nums.Length; k++)
            {
                nums[k] = (int)('A' + rnd.Next(26));
                Console.Write("| " + nums[k] + " ");
            }
            Console.WriteLine("|");

            Console.WriteLine("Массив в обратном порядке!");
            for (k = nums.Length - 1; k >= 0; k--)
            {
                Console.Write("| " + nums[k] + " ");
            }
            Console.Write("|");
        }
    }
}
