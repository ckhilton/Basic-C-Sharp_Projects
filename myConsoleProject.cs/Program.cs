using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {

            Console.Write("Welcome to the Insurance Qualifier app.\nLet's see if you qualify for car insurance today.");

            Console.WriteLine("\n\nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? (true or false)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQualified?");
            //==== BOOLEAN LOGIC FOR BUSINESS RULES
            bool qualified = (age > 15) && (DUI == false) && (tickets <= 3);
            Console.Write(qualified);

            Console.ReadLine();

        }
    }
}
