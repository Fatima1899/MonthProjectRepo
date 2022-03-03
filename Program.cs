using System;

namespace MonthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String month = "December";

            if (month == "December" || month == "January" || month == "February")
                Console.WriteLine("Winter");
            else if (month == "March" || month == "April" || month == "May")
                Console.WriteLine("Spring");
            else if (month == "June" || month == "July" || month == "August")
                Console.WriteLine("Summer");
            else if (month == "September" || month == "October" || month == "December")
                Console.WriteLine("Autumn");
        }
    }
}
