using System;
using System.Text;

namespace HW_08_Tak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("1a!2.3!!..4.!.? 6 7!..");
            Console.WriteLine(str);

            str.Replace("\\", "");
            Console.WriteLine(str);

            str.Replace(" ", "_");
            Console.WriteLine(str);
        }
    }
}