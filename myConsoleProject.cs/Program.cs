using System;
using System.Collections.Generic;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //DISPLAY STORY/STEP INFO FOR STORY/STEP 1 (AND 3)
            Console.WriteLine("//==== STORY/STEP 1 (INCLUDES REQUEST IN STORY/STEP 3) =====");

            //INSTANTIATE ONE-DIMENSIONAL ARRAY OF STRINGS
            string[] strArray = { "Happiness", "Joy", "Gladness", "Gratitude" };
            //ASK USER TO SELECT AN INDEX
            Console.WriteLine("\nPick a lucky number between 0 and 3:\n");
            //READ USER INPUT AND PASS INTO INTEGER VARIABLE CALLED 'strIndex'
            int strIndex = Convert.ToInt32(Console.ReadLine());

            //ADD MESSAGE IF INDEX CHOICE DOESN'T EXIST. ALLOW USER TO TRY AGAIN USING SWITCH AND DO WHILE LOOP
            bool strChoice = strIndex < 4;

            do
            {
                if (strIndex > 3)
                {
                    //MESSAGE IF INVALID NUMBER CHOSEN
                    Console.WriteLine("\n\tYou chose: " + strIndex +
                            "\n\t" + strIndex + " is not an option." +
                            "\n\tPlease choose a number between 0 and 3.");
                    //GET USER INPUT AGAIN
                    strIndex = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    //DISPLAY THE STRING AT THE INDEX THE USER CHOOSES IN 'strArray'
                    Console.WriteLine("\n\tBy choosing number " + strIndex + ", you chose to bring " + "\"" + strArray[strIndex] + "\" into your life today!");
                    break;
                }
            }
            while (!strChoice);

            //=========== PROGRAM PAUSE FOR NEXT STORY/STEP =================
            Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            Console.ReadLine();

            //DISPLAY STORY/STEP INFO FOR STORY/STEP 2 (AND 3)
            Console.WriteLine("//==== STORY/STEP 2 (INCLUDES REQUEST IN STORY/STEP 3) =====");
            //INSTANTIATE ONE-DIMENSIONAL ARRAY OF INTEGERS
            int[] intArray = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            // ASK USER TO SELECT AN INDEX
            Console.WriteLine("\nPlease select an index value between 0 and 10:\n");
            //READ USER INPUT AND PASS INTO VARIABLE CALLED 'intIndex'
            int intIndex = Convert.ToInt32(Console.ReadLine());

            //ADD MESSAGE IF INDEX CHOICE DOESN'T EXIST. ALLOW USER TO TRY AGAIN USING SWITCH AND DO WHILE LOOP
            bool intChoice = intIndex < 11;

            do
            {
                if (intIndex > 10)
                {
                    //MESSAGE IF INVALID NUMBER CHOSEN
                    Console.WriteLine("\n\tYou chose: " + intIndex +
                            "\n\t" + intIndex + " is not an option." +
                            "\n\tPlease choose a number between 0 and 10:");
                    //GET USER INPUT AGAIN
                    intIndex = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    //DISPLAY THE INTEGER AT THE INDEX THE USER CHOOSES IN 'intArray'
                    Console.WriteLine("\n\tThe integer in the Fibonacci sequence you chose at index " + intIndex + ", is " + intArray[intIndex] + ".");
                    break;
                }
            }
            while (!intChoice);

            //=========== PROGRAM PAUSE FOR NEXT STORY/STEP =================
            Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            Console.ReadLine();

            //DISPLAY STORY/STEP INFO FOR STORY/STEP 4 (ADDED STEP/STORY 3 FOR PRACTICE)
            Console.WriteLine("//============ STORY/STEP 4 (INCLUDES STEP 3 FOR PRACTICE) =============");
            //INSTANTIATE LIST OF STRINGS
            List<string> stringList = new List<string>() { "smart", "funny", "intelligent", "kind", "amazing", "brilliant" };
            //ASK USER TO SELECT AN INDEX
            Console.WriteLine("\nPick your favorite number between 0 and 5:\n");
            //READ USER INPUT AND PASS INTO VARIABLE CALLED 'intIndex'
            int listIndex = Convert.ToInt32(Console.ReadLine());

            //ADD MESSAGE IF INDEX CHOICE DOESN'T EXIST. ALLOW USER TO TRY AGAIN USING SWITCH AND DO WHILE LOOP
            bool listChoice = listIndex < 6;

            do
            {
                if (listIndex > 5)
                {
                    //MESSAGE IF INVALID NUMBER CHOSEN
                    Console.WriteLine("\n\tYou chose: " + listIndex +
                            "\n\t" + listIndex + " is not an option." +
                            "\n\tPick a lucky number between 0 and 5:");
                    //GET USER INPUT AGAIN
                    listIndex = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    //DISPLAY THE STRING AT THE INDEX THE USER CHOOSES IN 'strArray'
                    Console.WriteLine("\n\tYou chose number " + listIndex + ", which means today you are " + stringList[listIndex] + "!");
                    break;
                }
            }
            while (!listChoice);

            Console.ReadLine();
        }
    }
}
