using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //DECLARE VARIABLES


            //GET USER INPUT FOR WEIGHT
            Console.WriteLine("Please enter the package weight.");
            float weight = float.Parse(Console.ReadLine());

            //BRANCHING STOPS PROGRAM IF WEIGHT IS OVER 50
            if (weight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
            }
            //BRANCHING GETS PACKAGE DIMENSIONS IF WEIGHT IS LESS THAN 50
            else
            {
                //GET USER INPUT FOR WIDTH
                Console.WriteLine("\nPlease enter the package width.");
                float width = float.Parse(Console.ReadLine());               

                //GET USER INPUT FOR HEIGHT
                Console.WriteLine("\nPlease enter the package height.");
                float height = float.Parse(Console.ReadLine());               

                //GET USER INPUT FOR LENGTH
                Console.WriteLine("\nPlease enter the package length.");
                float length = float.Parse(Console.ReadLine());

                //BRANCHING LOGIC IF THE DIMENSIONS TOTAL UP TO MORE THAN 50
                if (width + height + length > 50)
                    {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                }
                //FINAL BRANCHING LOGIC TO GIVE FULL QUOTE IF ALL REQUIREMENTS MET.
                else
                {
                    float quote = ((width * height * length) * (weight)) / (100);
                    Console.WriteLine("\nYour estimated total for shipping is: $" + quote);
                }
             }

            Console.ReadLine();

        }
    }
}
