using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n//BOOLEAN COMPARISON USING A WHILE STATEMENT");
            Console.WriteLine("\n\tGuess my first name. Use a corresponding number from the list below:" +
                //NOT NECESSARY TO ASSIGN NUMBERS, BUT I'M CONTROLLING INPUT BY MAKING IT EASIER FOR THE USER
                "\n\n\t\t1 = Jeremy" +
                "\n\t\t2 = Steven" +
                "\n\t\t3 = Anthony" +
                "\n\t\t4 = Christopher" +
                "\n\t\t5 = Andrew");
            int nameNum = Convert.ToInt32(Console.ReadLine());
            bool guessed = false;

            while (!guessed)
            {
                switch (nameNum)
                {
                    case 1:
                        Console.WriteLine("\n\tIt's not Jeremy. Try again!\n");
                        nameNum =  Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\n\tIt's not Steven. Try again!\n");
                        nameNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("\n\tIt's not Anthony. Try again!\n");
                        nameNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("\n\tYou got it! My first name is 'Christopher'. My middle name is 'Kirk'.");
                        guessed = true;
                        break;
                    case 5:
                        Console.WriteLine("\n\tIt's not Andrew. Try again!\n");
                        nameNum = Convert.ToInt32(Console.ReadLine());
                        break;                   
                    default:
                        Console.WriteLine("\n\tOptions are numbers between 1 and 5. Try again.\n");
                        nameNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("\n\tPRESS ENTER TO CONTINUE");
            Console.ReadLine();

            Console.WriteLine("\n//BOOLEAN COMOPARISON USING A DO WHILE STATEMENT");
            Console.WriteLine("\n\tGame: Guess a number between 1 and 5.\n");
            int num = Convert.ToInt32(Console.ReadLine());
            bool pick = num == 3;

            do
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("\n\tSorry, try again.\n");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\n\tSorry, try again.\n");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("\n\tNice! You guessed it!\n\n\tTHANKS FOR PLAYING!");
                        pick = true;
                        break;
                    case 4:
                        Console.WriteLine("\n\tSorry, try again.\n");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("\n\tSorry, try again.\n");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;                    
                    default:
                        Console.WriteLine("\n\tOnly guess numbers between 1 and 5. Try again.\n");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!pick);

            Console.ReadLine();
        }
    }
}
