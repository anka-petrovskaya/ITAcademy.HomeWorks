using System;
using System.Text.RegularExpressions;

namespace HW_07_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в следующем формате: строка 1; строка 2; строка 3 и так далее.");
            string strTxt = Console.ReadLine();
            strTxt.Split(';');
            strTxt = strTxt.Replace("O", "A");
            char[] myArray = strTxt.ToCharArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
