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

            Console.WriteLine("Please enter any number and I will multiply it by 50: ");
            double inputNumber1 = double.Parse(Console.ReadLine());
            Console.WriteLine(inputNumber1 + " x 50 = " + inputNumber1 * 50);
            
            Console.WriteLine("\nPlease enter any number and I will add 25 to it: ");
            double inputNumber2 = double.Parse(Console.ReadLine());
            Console.WriteLine(inputNumber2 + " + 25 = " + (inputNumber2 + 25));

            Console.WriteLine("\nPlease enter any number and I will divide it by 12.5: ");
            double inputNumber3 = double.Parse(Console.ReadLine());
            Console.WriteLine(inputNumber3 + " / 12.5 = " + (inputNumber3 / 12.5));

            Console.WriteLine("\nPlease enter any number: ");
            double inputNumber4 = double.Parse(Console.ReadLine());
            double maxValue = 50.0d;
            bool comparison = inputNumber4 > maxValue;
            Console.WriteLine(inputNumber4 + " is greater than 50: " + comparison);

            Console.WriteLine("\nPlease enter any number and I will divide it by 7 and show you the remainder: ");
            double inputNumber5 = double.Parse(Console.ReadLine());
            int inputNumber5Int = Convert.ToInt32(inputNumber5);
            Console.WriteLine(inputNumber5Int + " / 7 = " + (inputNumber5Int / 7) + " remainder " + (inputNumber5Int % 7));


            //A LITTLE EXTRA JUST FOR FUN
            Console.WriteLine("\nNow let's play a game! Choose a number between 1 and 100.");

            Random randomNumber = new Random();

            int winningNumber = randomNumber.Next(1, 100);
            bool win = false;

            do
            {
                Console.Write("\nEnter your guess: ");
                string answer = Console.ReadLine();
                int answerInt = int.Parse(answer);
                if (answerInt > winningNumber)
                {
                    Console.WriteLine("\nToo high! Try again...");
                }
                else if (answerInt < winningNumber)
                {
                    Console.WriteLine("\nToo low! Try again...");
                }
                else if (answerInt == winningNumber)
                {
                    Console.WriteLine("\nWINNER WINNER CHICKEN DINNER! THANKS FOR PLAYING!");
                    win = true;
                }
            } 
            while (win == false);

            Console.WriteLine("\nPress any key to finish.");
            Console.ReadKey(true);

        }
    }
}
