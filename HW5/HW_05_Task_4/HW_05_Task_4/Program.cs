using System;

namespace HW_05_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter your word");
            string yourword = Console.ReadLine();

            for (int i = 0; i < yourword.Length; ++i)
                if (yourword[i] == 'A' || yourword[i] == 'a' || yourword[i] == 'А' || yourword[i] == 'а')
                    count++;

            Console.WriteLine(count);             
        }
    }
}


