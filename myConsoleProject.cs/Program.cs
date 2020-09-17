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

            //CONSOLE APP ASSSIGNMENT STEP 197
            Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 197 =====");

            //INSTANTIATE ARRAY OF STRINGS WITH NAMES
            string[] phrases = { "\tHello, ", "\tIt's nice to meet you, ",
                "\tI once had a pet named ", "\tPlease don't be mad about that, ",
                "\tI was totally just kidding, ", "\tCool, I'm glad we can still be friends, ",
                "\tNice chatting with you. Goodbye for now, " };
            //ASK FOR USER INPUT
            Console.WriteLine("\nHey there, what's your first name?\n");
            string name = Console.ReadLine();
            //GIVE THE USER INSTRUCTIONS
            Console.WriteLine("\n\t(PRESS ENTER TO CONTINUE THROUGH EACH LINE)");
            //ITERATE THROUGH EACH STRING
            for (int p = 0; p < phrases.Length; p++)
            {      
                //PAUSE AFTER EACH LINE IS PRINTED
                //Console.ReadLine();
                Console.WriteLine(phrases[p] + name + ".");
            }

            ////CONSOLE APP ASSSIGNMENT STEP 198
            //Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 198 =====");


            //foreach (string phrase in phrases)
            //{
            //    Console.WriteLine(phrase + name);
            //}

            Console.ReadLine();


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
