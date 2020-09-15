using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, my name is: \n" + name + "!");
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();


            //THE FOLLOWING ARE JUST EXAMPLES OF DATA TYPES
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char oneCharacter = 't';
            char randomLetter = 'X';
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; //NOTE THE 'm' IS REQUIRED AFTER DECIMALS (WAS MADE FOR MONEY)
            double heightInCentimeters = 211.30204234; //ANY NUMBER 15 OR 16 UNITS IN LENGTH (CAN HAVE DECIMALS IN IT)
            float secondsLeft = 2.62f; //ONLY UP TO 7 DIGITS IN LENGTH. NOTE THE 'f' IS NEEDED TO NO IT'S A FLOAT AND NOT A DECIMAL. 
            short tempepratureOnMars = -341; //WHOLE NUMBER BETWEEN -32000 AND 32000
            string myName = "Kirk"; //NEEDS DOUBLE QUOTES

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(isRaining);
            Console.ReadLine();
        }
    }
}
