using System;

namespace HW_06_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] nums = new int[size];

            for (int i = 0; i < nums.Length-1; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i};\t ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив чисел введенных!");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("| " + nums[i] + " ");
            }
            Console.WriteLine("|");

            Insert(ref nums, 12, 4);

            Console.WriteLine("Обновленный Массив чисел введенных!");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("| " + nums[i] + " ");
            }
            Console.WriteLine("|");

        }

        static void Insert(ref int[] nums, int value, int index)
        {
            int[] newnums = new int[nums.Length + 1];
            newnums[index] = value;

            for (int i = 0; i < index; i++)
                newnums[i] = nums[i];

            for (int i = index; i < nums.Length; i++)
                newnums[i + 1] = nums[i];

            nums = newnums;
        }
    }
}
