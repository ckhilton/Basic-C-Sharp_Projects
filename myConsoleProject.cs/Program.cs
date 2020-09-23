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
            try //WHAT WE WANT IT TO DO
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two numbers...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); //COULD ALSO WRITE A CUSTOM MESSAGE LIKE THIS... Console.WriteLine("PLEASE TYPE A WHOLE NUMBER");
                return; //STOPS THE PROGRAM AND MAY SENT THE USER TO ANOTHER PAGE, ETC.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("PLEASE DON'T DIVIDE BY ZERO");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //GENERIC EXCEPTION MESSAGE
            }
            finally //ALWAYS RUNS NO MATTER WHAT, USUALLY USED FOR LOGGING ERRORS TO A DATABASE
            {
                Console.ReadLine();
            }
                     
        }           
    }
}
