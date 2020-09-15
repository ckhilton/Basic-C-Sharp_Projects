using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy\nStudent Daily Report:\n");

            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("\nWhat page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\"");
            string helpNeeded = Console.ReadLine();
            bool helpNeed = Convert.ToBoolean(helpNeeded);

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStud = Convert.ToInt32(hoursStudied);

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();

        }
    }
}
