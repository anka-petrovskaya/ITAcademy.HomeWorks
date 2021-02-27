using System;
using System.Linq;

namespace HW_7_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTxt = "apple a day keeps a doctor away";
        }
        static void TheLongestWord(string strTxt)
        {
            string[] words = strTxt.Split(' ');
            int max = 0;

            foreach (string word in words)
                if (word.Length > max)
                    max = word.Length;
            Console.WriteLine(max);
            strTxt = strTxt.Remove(max);
            Console.WriteLine(strTxt);
        }
        static void ChangePlaces(string strTxt)
        {
            string[] words = strTxt.Split(' ');
            int max = 0;
            int min = 1;

            foreach (string word in words)
                if (word.Length > max)
                    max = word.Length;
            Console.WriteLine(max);

            foreach (string word in words)
                if (word.Length < min)
                    min = word.Length;
            Console.WriteLine(min);
            strTxt = strTxt.Replace((char)max, (char)min);
            Console.WriteLine(strTxt);
        }
        static void CountSymbols(string strTxt)
        {
            Console.WriteLine(strTxt.Count(char.IsPunctuation));
            Console.WriteLine(strTxt.Count(char.IsLetter));
        }
        static void MyArray(string strTxt)
        {
            string[] words = strTxt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int max = 0;
            int min = 1;

            foreach (string word in words)
                if (word.Length < min)
                    min = word.Length;
            foreach (string word in words)
                if (word.Length > max)
                    max = word.Length;


            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}