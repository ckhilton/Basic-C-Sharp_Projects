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
            //========================== STEP 207 ASSIGNMENT ==============================
            Console.Write("\n=========================== STEP 207 ASSIGNMENT ===========================\n" +
                "\n\t(PRESS ENTER TO DISPLAY A LIST OF MY CHOSEN INTEGERS)\n");
            Console.ReadLine();

            //CREATE A LIST OF INTEGERS
            List<int> integers = new List<int>() { 100, 50, 8, 364, 24, 30, 66 };
            //PRINT LIST TO CONSOLE
            foreach (int integer in integers)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine("");

            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {                    
                    
                    //GET USER INPUT
                    Console.WriteLine("\tTYPE IN ANY RANDOM INTEGER YOU WANT\n");
                    //STORE USER INPUT IN VARIABLE
                    int userNumber = Convert.ToInt32(Console.ReadLine());                                                                               
                    //CREATE LOOP
                    foreach (int integer in integers)
                    {
                        int answer = integer / userNumber;
                        Console.WriteLine("\n\t" + integer + " \u00F7 " + userNumber + " = " + answer);
                    }
                }

                //================ EXCEPTION HANDLING ================
                //DIVIDE BY ZERO CATCH
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("\n\tNICE TRY THERE! BUT........ " +
                        "\n\n\t- YOU " + ex.Message.ToUpper() +
                        "\n\n\t- COME ON NOW, CHOOSE ANY OTHER INTEGER THAN ZERO." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                    
                }
                //WRONG FORMAT CATCH
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\tTISK TISK, WRONG FORMAT!!! " +
                        "\n\n\t   - TEXT NOT ALLOWED. " +
                        "\n\n\t   - WHOLE NUMBERS ONLY. " +
                        "\n\n\t   - NULL IS NOT ACCEPTABLE EITHER" +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();                   
                }
                //GENERAL EXCEPTION IF TOO LARGE OF OR TOO SMALL OF AN INTEGER WERE ENTERED)
                catch (Exception ex)
                {
                    Console.WriteLine("\n\tEASY DOES IT THERE!!!" +
                        "\n\n\t- YOUR" + ex.Message.ToUpper() +
                        "\n\n\t- NOT TOO BIG." +
                        "\n\n\t- NOT TOO NEGATIVE" +
                        "\n\n\t- NICE AND EASY..." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                }
                //INSTRUCTIONS TO USER (***NOTE TO SELF: FINALLY BLOCK ALWAYS EXECUTES NO MATTER WHAT)
                finally
                {
                    //PROGRAM NOTE
                    Console.Write("\n================ THE PROGRAM HAS NOW EMERGED FROM THE TRY/CATCH BLOCK ================\n\n" +
                        "\n\t\t      **** (PRESS ENTER TO TEST ANOTHER INPUT) ****\n\n\t\t\t" +
                        "\t        OR\n\n" +
                        "\t\t         XXX (PRESS \'X\' THEN ENTER TO EXIT) XXX\n\n" +
                        "\n======================================================================================\n\n");
                    string exit = Console.ReadLine();
                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
                    if ((exit == "x") || (exit == "X"))
                    {
                        executing = false;                      
                    }
                }               
            }
            while (executing);
        }           
    }
}
