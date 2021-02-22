using System;

namespace HW_6_task_1
{
    class Program
    {
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

            int size1 = 10;
            int[] nums1 = new int[size1];

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i};\t ");
                nums1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив чисел введенных!");

            for (int i = 0; i < nums1.Length; i++)
            { 
                Console.Write("| " + nums1[i] + " ");
            }
            Console.WriteLine("|");

            int size2 = 10;
            int[] nums2 = new int[size2];

            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] = nums1[i] + nums[i];
                Console.Write("| " + nums2[i] + " ");
            }
            Console.WriteLine("|");
        }
    }
}
