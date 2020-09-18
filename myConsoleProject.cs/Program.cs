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

            ////=============== CONSOLE APP ASSSIGNMENT STEP 197 ==================
            //Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 197 =====");

            ////INSTANTIATE ARRAY OF STRINGS WITH NAMES
            //string[] phrases = { "\tHello, ", "\tIt's nice to meet you, ",
            //    "\tI once had a pet named ", "\tPlease don't be mad about that, ",
            //    "\tI was totally just kidding, ", "\tCool, I'm glad we can still be friends, ",
            //    "\tNice chatting with you. Goodbye for now, " };
            ////ASK FOR USER INPUT
            //Console.WriteLine("\nHey there, what's your first name?\n");
            //string name = Console.ReadLine();
            ////GIVE THE USER INSTRUCTIONS
            //Console.WriteLine("\n\t(PRESS ENTER TO CONTINUE THROUGH EACH LINE)");
            ////ITERATE THROUGH EACH STRING
            //for (int p = 0; p < phrases.Length; p++)
            //{
            //    //PAUSE AFTER EACH LINE IS PRINTED
            //    Console.ReadLine();
            //    Console.WriteLine(phrases[p] + name + ".");
            //}
            //Console.ReadLine();
            //Console.WriteLine("\tPRESS ENTER TO CONTINUE TO NEXT STEP");
            //Console.ReadLine();

            ////============= CONSOLE APP ASSSIGNMENT STEP 198 ====================
            //Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 198 =====");
            //Console.WriteLine("\nTHIS WILL ITERATE THROUGH THE INTEGER LIST ONLY ONCE. (PRESS ENTER)");
            ////PROGRAM PAUSE
            //Console.ReadLine();

            ////INSTANTIATE LIST OF STRINGS WITH NAMES
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////SET UP A WHILE LOOP AND THEN FIX IT WITH A DO-WHILE LOOP
            //bool numList = true;

            //do
            //{
            //    //ITERATE THROUGH EACH NUMBER
            //    foreach (int number in numbers)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //while (!numList);
            //Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            //Console.ReadLine();

            ////============= CONSOLE APP ASSSIGNMENT STEP 199 ====================
            //Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 199 =====\n" +
            //    "\nTHIS WILL ITERATE THROUGH AND DISPLAY SHOE SIZES SMALLER THAN 10.5 (PRESS ENTER)");            
            //Console.ReadLine();

            ////INSTANTIATE LIST OF STRINGS WITH NAMES
            //List<float> shoeSizes  = new List<float>() { 10.5f, 11.5f, 10.0f, 9.0f,
            //    9.5f, 11.0f, 12.0f, 10.5f, 11.0f, 10.0f, 11.5f, 10.0f, 9.0f, 9.5f,
            //    9.5f, 11.0f, 12.0f, 9.5f, 11.0f, 9.0f, 12.0f, 13.0f, 11.5f, 12.5f };

            ////ORDER LIST DESCENDING BY CREATING NEW VARIABLE LIST
            //var sortedSizes = shoeSizes.OrderByDescending(item => item).ToList();

            ////ITERATE THROUGH EACH NUMBER
            //foreach (float size in sortedSizes)
            //{
            //    //USE LESS THAN OPERATOR TO SEARCH FOR SHOES SMALLER THAN 10.5
            //    if (size < 10.5f)
            //    {
            //        Console.WriteLine(size);
            //    }
            //}
            //Console.WriteLine("\nNOW IT WILL ITERATE THROUGH THE LIST, BUT INCLUDE SIZE 10.5. (PRESS ENTER)");
            //Console.ReadLine();

            ////USE LESS THAN OR EQUAL TO AND INCLUDES SIZE 10.5
            //foreach (float size in sortedSizes)
            //{   
            //    if (size <= 10.5f)
            //    {
            //        Console.WriteLine(size);
            //    }
            //}
            //Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            //Console.ReadLine();

            //============= CONSOLE APP ASSSIGNMENT STEP 200 ====================
            Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 200 =====");
            //GIVE INSTRUCTIONS
            Console.WriteLine("\nPRESS ENTER TO VIEW THE CONTESTANT LIST OF THE 2020 HILTON FAMILY ANNUAL THUMB-WAR BATTLE");
            Console.ReadLine();
            Console.WriteLine("\tCONTESTANTS:" +
                "\n\n\tVince\n\tDrew" +
                "\n\tKirk\n\tSteph" +
                "\n\tRob\n\tDave" +
                "\n\tJeff\n\tBrighton" +
                "\n\tLily\n\tMaisy");
            //ASK USER TO SEARCH FOR A FINALIST NAME IN THE LIST
            Console.WriteLine("\nNOW TYPE ANY NAME FROM ABOVE " +
                "TO SEE IF THEY MADE IT TO THE FINALS ROUND\n");
            //INSTANTIATE LIST OF ACTUAL FINALISTS
            List<string> finalist_List = new List<string>() { "Vince", "Drew", "Kirk", "Steph", "Rob", "Dave", "Jeff", "Brighton", "Lily", "Maisy" };
            //STORE USER INPUT AND STORE AS VARIABLE 'contestant'
            string contestant = Console.ReadLine();

            
            //SET UP VARIABLE FOR DO-WHILE LOOP
            bool contest = false;

            do
            {
                switch (contestant)
                {
                    case string 'Kirk':



                }
            }
            while (!contest);

            Console.ReadLine();

            //foreach (string finalist in finalist_List)
            //{
            //    if (finalist != contestant)
            //    {
            //        Console.WriteLine("\n" + contestant + " lost and did not make it to the finals. Try another name.\n");
            //        contestant = Console.ReadLine();
            //        //contest = true;
            //    }
            //    if (finalist == contestant)
            //    {
            //        Console.WriteLine("\nYep! " + finalist + " made it to the finals. Try another name.\n");
            //        contestant = Console.ReadLine();            
            //    }
            //}   









            //ITERATION

            ////INSTANTIATE INTEGER ARRAY WITH TEST SCORES
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //ITERATION THROUGH AN ARRAY OF STRINGS
            //string[] names = { "Kirk", "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}

            //ITERATION THROUGH A LIST
            //INSTATIATE A NEW LIST OBJECT CALLED 'testScores' USING THE CLASS 'List<int>'
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "Kirk", "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //    //WILL ITERATE THROUGH AND DISPLAY EACH PASSING SCORE ON A NEW LINE
            //    Console.WriteLine(score);
            //}

            //Console.WriteLine("There were " + passingScores.Count + " passing scores.");
            //Console.ReadLine();
        }
    }
}
