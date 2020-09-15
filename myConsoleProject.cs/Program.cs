using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy\nStudent Daily Report:\n");

            Console.WriteLine("What is your name?");
            string myName = "Kirk";
            Console.WriteLine(myName + "\n");

            Console.WriteLine("What course are you on?");
            string courseName = "C# & .NET Framework Course\n";
            Console.WriteLine(courseName);

            Console.WriteLine("What page number?");
            ushort pageNumber = 133;
            Console.WriteLine(pageNumber + "\n");

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool helpNeeded = false;
            Console.WriteLine(helpNeeded + "\n");

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = "Just moving forward and more learning C#.";
            Console.WriteLine(positiveExperiences + "\n");

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = "I'm not certain if this is the format you wanted this assignment in.";
            Console.WriteLine(feedback + "\n");

            Console.WriteLine("How many hours did you study today?");
            ushort hoursStudied = 10;
            Console.WriteLine(hoursStudied + "\n");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();

        }
    }
}