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
            Console.Write("\n=========================== STEP 207 ASSIGNMENT =============================\n" +
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
                    Console.WriteLine("TYPE IN ANY RANDOM NUMBER YOU WANT\n");
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
                    Console.WriteLine("\nNICE TRY! YOU " + ex.Message.ToUpper() + " PLEASE CHOOSE A NON-ZERO NUMBER." +
                        "\n\nPRESS ENTER TO LEAVE THE TRY-CATCH BLOCK");
                    Console.ReadLine();
                    
                }
                //WRONG FORMAT CATCH
                catch (FormatException ex)
                {
                    Console.WriteLine("\nTISK TISK! TEXT NOT ALLOWED. NULL IS NOT ACCEPTABLE EITHER!" +
                        "\n\nPRESS ENTER TO LEAVE THE TRY-CATCH BLOCK");
                    Console.ReadLine();                   
                }
                //GENERAL EXCEPTION CATCH
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToUpper() +
                        "\n\nPRESS ENTER TO LEAVE THE TRY-CATCH BLOCK");
                    Console.ReadLine();
                }
                //INSTRUCTIONS TO USER (***NOTE TO SELF: FINALLY BLOCK ALWAYS EXECUTES NO MATTER WHAT)
                finally
                {
                    //PROGRAM NOTE
                    Console.Write("\n===== THE PROGRAM HAS NOW EMERGED FROM THE TRY/CATCH BLOCK. =====\n" +
                        "\n\t  *** (PRESS ENTER TO TEST ANOTHER INPUT) ***\n\n\t\t\t" +
                        "     OR\n\n" +
                        "\t    XXX (PRESS \'X\' THEN ENTER TO EXIT) XXX\n");
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
