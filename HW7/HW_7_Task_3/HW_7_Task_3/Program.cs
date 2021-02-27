using System;
using System.Linq;

namespace HW_7_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTxt = "as12d12f+h12jkl12";
            Console.WriteLine(strTxt);

            string[] words = strTxt.Split('+', '-', '*', '/');

            foreach (string word in words)
            {
                int number;

                bool success = int.TryParse(word, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", word, number);
                }
                else
                    Console.WriteLine("Attempted conversion of '{0}' failed.");




                //char[] symbs = strTxt.ToCharArray();

                //for (int i = 0; i < symbs.Length; i++)
                //{
                //    Console.WriteLine(symbs[i] + " ");
                //}

                //foreach (char value in symbs)
                //{
                //    int number;

                //    bool success = int.TryParse(value, out number);
                //    if (success)
                //    {
                //        Console.WriteLine("Converted '{0}' to {1}.", value, number);
                //    }
                //}
            }
        }
    }
}