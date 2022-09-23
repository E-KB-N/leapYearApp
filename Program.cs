using System;
namespace leapchkYearTest
{
    class Program
    {
        static void Main(String[] args)
        {
            int chkYear;
            Console.WriteLine("");
            Console.WriteLine("Check whether a given year is leap year or not: ");
            Console.WriteLine("................................. ");
            Console.WriteLine("");
            Console.WriteLine("Enter year: ");
            chkYear = Convert.ToInt32(Console.ReadLine());

            if (chkYear % 400 == 0)
            {
                Console.Write(chkYear + " is a leap Year.");
            }
            else if (chkYear % 100 == 0)
            {
                Console.Write(chkYear + " is not a leap Year.");
            }
            else if (chkYear % 4 == 0)
            {
                Console.Write(chkYear + " is a leap Year.");
            }
            else
            {
                Console.Write(chkYear + " is not a leap Year.");
            }

        }
    }
}