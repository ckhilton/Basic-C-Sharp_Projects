using System;
using System.Collections.Generic;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //DISPLAY STORY INFO
            Console.WriteLine("//==== STORY/STEP 1 (INCLUDES REQUEST IN STORY/STEP 3) =====");

            //INSTANTIATE ONE-DIMENSIONAL ARRAY OF STRINGS
            string[] strArray = { "Happy", "Joy", "Glad", "Smile" };
            //ASK USER TO SELECT AN INDEX
            Console.WriteLine("\nPlease select an index value between 0 and 3:\n");
            //READ USER INPUT AND PASS INTO INTEGER VARIABLE CALLED 'strIndex'
            int strIndex = Convert.ToInt32(Console.ReadLine());

            //ADD MESSAGE IF INDEX CHOICE DOESN'T EXIST. ALLOW USER TO TRY AGAIN USING SWITCH AND DO WHILE LOOP
            bool strChoice = strIndex < 4; /*(strIndex == 1) || (strIndex == 2) || (strIndex == 3);*/

            do
            {
                if (!strChoice)
                {
                    Console.WriteLine("\n\tYou chose: " + strIndex +
                            "\n\tThat index does not exist." +
                            "\n\tPlease select an index between 0 and 3.");
                    strIndex = Convert.ToInt32(Console.ReadLine());
                }
                else
                {

                }


            }

            do
            {
                switch (strIndex)
                {
                    case 0:
                        //DISPLAY THE STRING AT THE INDEX THE USER CHOOSES IN 'strArray' (USE OF VARIABLES TO COPY AND PASTE CODE FASTER)
                        Console.WriteLine("\n\tThe word you chose at index " + strIndex + " is: " + "\"" + strArray[strIndex] + "\"");
                        strChoice = true;
                        break;
                    case 1:
                        Console.WriteLine("\n\tThe word you chose at index " + strIndex + " is: " + "\"" + strArray[strIndex] + "\"");
                        strChoice = true;
                        break;
                    case 2:
                        Console.WriteLine("\n\tThe word you chose at index " + strIndex + " is: " + "\"" + strArray[strIndex] + "\"");
                        strChoice = true;
                        break;
                    case 3:
                        Console.WriteLine("\n\tThe word you chose at index " + strIndex + " is: " + "\"" + strArray[strIndex] + "\"");
                        strChoice = true;
                        break;
                    default:
                        Console.WriteLine("\n\tYou chose: " + strIndex +
                            "\n\tThat index does not exist." +
                            "\n\tPlease select an index between 0 and 3.");
                        //READ USER INPUT AGAIN
                        strIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!strChoice);   

            //==== PROGRAM PAUSE ====
            Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            Console.ReadLine();

            //DISPLAY STORY(STEP) INFO
            Console.WriteLine("//==== STORY/STEP 2 (INCLUDES REQUEST IN STORY/STEP 3) =====");
            //INSTANTIATE ONE-DIMENSIONAL ARRAY OF INTEGERS
            int[] intArray = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            // ASK USER TO SELECT AN INDEX
            Console.WriteLine("\nPlease select an index value between 0 and 10:\n");
            //READ USER INPUT AND PASS INTO VARIABLE CALLED 'intIndex'
            int intIndex = Convert.ToInt32(Console.ReadLine());

            //ADD MESSAGE IF INDEX CHOICE DOESN'T EXIST. ALLOW USER TO TRY AGAIN USING SWITCH AND DO WHILE LOOP
            bool intChoice = (intIndex < 11);

            do
            {
                switch (intIndex)
                { 
                    case 0:
                        //DISPLAY THE STRING AT THE INDEX THE USER CHOOSES IN 'strArray' (USE OF VARIABLES TO COPY AND PASTE CODE FASTER)
                        Console.WriteLine("\n\tThe integer you chose at index " + intIndex + " is: " + intArray[intIndex]);
                    intChoice = true;
                    break;
                }
            }
            while (!intChoice);

            Console.ReadLine();


            //=========== LIST FUNDAMENTALS =======================

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Add(5);

            //Console.WriteLine(intList[1]);
            //Console.ReadLine();

            //List<string> stringList = new List<string>();
            //stringList.Add("Hello");
            //stringList.Add("Kirk");
            //stringList.Add("Hilton");

            //Console.WriteLine(stringList[1]);
            //Console.ReadLine();


            ////========= ARRAY FUNDAMENTNALS ==================== 
            ////(BEST WHEN YOU HAVE A FIXED NUMBER OF THINGS OR A VERY LARGE NUMBER OF THINGS)
            //
            ////CREATING AN ARRAY THE MOST EASY TO UNDERSTAND
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Console.WriteLine(numArray[3]); //OUTPUT WILL BE 200

            ////AN EASIER WAY TO DO THE SAME THING AS ABOVE
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //Console.WriteLine(numArray1[3]); //OUTPUT WILL BE 200 (DON'T FORGET TO COUNT STARTING AT INDEX '0')

            ////THE EASIEST WAY IS A SHORTCUT (JUST USE CURLY BRACKETS ON RIGHT SIDE)
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //Console.WriteLine(numArray2[3]); //OUTPUT WILL BE 200 AGAIN

            ////TO CHANGE ONE OF THE ARRAY VALUES
            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]); //OUTPUT WILL CHANGE FROM 600 TO 650

            //STORING INFORMATION AS BINARY INFORMATION (FOR VERY LARGE QUANTITIES OF DATA)
            //byte[] byteArray = new byte[5000];

            //Console.ReadLine();
        }
    }
}
