using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear User!");
            Console.WriteLine("Let's check your Birthday.");
            Console.WriteLine("Please enter your month of Birthday from 1 to 12");
            string monthTxt = Console.ReadLine();
            Console.WriteLine("Please enter your year of Birthday e.g. 1993");
            string yearTxt = Console.ReadLine();
            int usermonth = Convert.ToInt32(monthTxt);
            int useryear = Convert.ToInt32(yearTxt);
            Console.WriteLine("Now please enter the current month from 1 to 12");
            string currentmonthTxt = Console.ReadLine();
            Console.WriteLine("And enter the current year e.g. 2021");
            string currentyearTxt = Console.ReadLine();
            int currentusermonth = Convert.ToInt32(currentmonthTxt);
            int currentuseryear = Convert.ToInt32(currentyearTxt);
            if (currentusermonth < usermonth ||
                (currentusermonth == usermonth))
            {
                Console.WriteLine(currentuseryear - useryear - 1);
            }
        }
    }
}
