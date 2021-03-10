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
            strTxt = strTxt.Remove(max);
        }
        static void ChangePlaces(string strTxt)
        {
            string[] words = strTxt.Split(' ');
            int max = 0;
            int min = 1;

            foreach (string word in words)
                if (word.Length > max)
                    max = word.Length;

            foreach (string word in words)
                if (word.Length < min)
                    min = word.Length;
            strTxt = strTxt.Replace((char)max, (char)min);
        }
        static void CountSymbols(string strTxt)
        {
            Console.WriteLine(strTxt.Count(char.IsPunctuation));
            Console.WriteLine(strTxt.Count(char.IsLetter));
        }
        static void MyArray(string strTxt)
        {
            string[] words = strTxt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] myArray = strTxt.ToCharArray();
            char symb;
            for (int i = 0; i < myArray.Length; i++)
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j] > myArray[j+1])
                    {
                        symb = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = symb;
                    }
                }
        }
    }
}