using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear User!");
            Console.WriteLine("Plesae enter number 1");
            string s = Console.ReadLine();
            

                if (!IsAllDigits(s))
                {
                    Console.WriteLine("It is not a number. Pease enter a correct number");
                }
                else
                {
                    int n1 = Int32.Parse(s);
                    Console.WriteLine("Please enter number 2");
                    string z = Console.ReadLine();
                if (!IsAllDigits(z))
                {
                    Console.WriteLine("It is not a number. Pease enter a correct number");
                }
                else
                {
                    int n2 = Int32.Parse(z);
                    Console.WriteLine(n2 + n1);
                }
            }

             static bool IsAllDigits(string raw)
            {
                string s = raw.Trim();
                if (s.Length == 0)
                {
                    return false;
                }
                for (int index = 0; index < s.Length; index++)
                {
                    if (Char.IsDigit(s[index]) == false)
                    {
                        return false;
                    }
                }
                return true;
            }
        } 
    }
}




