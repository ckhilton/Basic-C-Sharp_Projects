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

            //============================== CONSOLE APP ASSIGNMENT STEP 197 ==================================
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 197 ==================================");
            //ASK FOR USER INPUT
            Console.WriteLine("\nHELLO. PLEASE ENTER YOUR FIRST NAME.\n");
            string name = Console.ReadLine();
            //INSTANTIATE ARRAY OF STRINGS WITH NAMES
            string[] phrases = { "\tHello. It's nice to meet you, ",
                "\tI once had a pet named ", "\tThat's actually not true at all, ",
                "\tTotally kidding, ", "\tNice chatting with you though! ;-)\n\n" +
                "\tGoodbye for now, " };
            //GIVE THE USER INSTRUCTIONS
            Console.WriteLine("\n\t(PRESS ENTER TO CONTINUE THROUGH EACH LINE)");
            //ITERATE THROUGH EACH STRING
            for (int p = 0; p < phrases.Length; p++)
            {
                //PAUSE AFTER EACH LINE IS PRINTED
                Console.ReadLine();
                Console.WriteLine(phrases[p] + name + ".");
            }
            Console.ReadLine();
            Console.WriteLine("\tPRESS ENTER TO CONTINUE TO NEXT STEP\n\n\n");
            Console.ReadLine();

            //============================== CONSOLE APP ASSIGNMENT STEP 198 ==================================
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 198 ==================================");
            Console.WriteLine("\nTHIS WILL ITERATE THROUGH THE INTEGER LIST FROM 1 TO 10 ONLY ONCE. (PRESS ENTER)");
            //PROGRAM PAUSE
            Console.ReadLine();

            //INSTANTIATE LIST OF STRINGS WITH NAMES
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //INFINITE LOOP THAT NEEDS FIXING
            //while (numList)
            //{
            //    //ITERATE THROUGH EACH NUMBER
            //    foreach (int number in numbers)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //CREATE BOOLEAN VARIABLE FOR DO-WHILE LOOP CONTROL
            bool numList = true;

            //FIXED LOOP
            do
            {
                //ITERATE THROUGH EACH NUMBER
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            while (!numList);
            Console.WriteLine("\nPRESS ENTER TO CONTINUE\n\n\n");
            Console.ReadLine();

            //============================== CONSOLE APP ASSIGNMENT STEP 199 ==================================");
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 199 ==================================" +
                "\n\nTHIS WILL ITERATE THROUGH AND DISPLAY SHOE SIZES IN MY LIST SMALLER THAN 10.5 (PRESS ENTER)");
            Console.ReadLine();

            //INSTANTIATE LIST OF STRINGS WITH NAMES
            List<float> shoeSizes = new List<float>() { 10.5f, 11.5f, 10.0f, 9.0f,
                9.5f, 11.0f, 12.0f, 10.5f, 11.0f, 10.0f, 11.5f, 10.0f, 9.0f, 9.5f,
                9.5f, 11.0f, 12.0f, 9.5f, 11.0f, 9.0f, 12.0f, 13.0f, 11.5f, 12.5f };

            //ORDER LIST DESCENDING BY CREATING NEW VARIABLE LIST
            var sortedSizes = shoeSizes.OrderByDescending(item => item).ToList();

            //ITERATE THROUGH EACH NUMBER
            foreach (float size in sortedSizes)
            {
                //USE LESS THAN OPERATOR TO SEARCH FOR SHOES SMALLER THAN 10.5
                if (size < 10.5f)
                {
                    Console.WriteLine(size);
                }
            }
            Console.WriteLine("\nNOW IT WILL ITERATE THROUGH THE LIST, BUT INCLUDE SIZE 10.5. (PRESS ENTER)");
            Console.ReadLine();

            //USE LESS THAN OR EQUAL TO AND INCLUDES SIZE 10.5
            foreach (float size in sortedSizes)
            {
                if (size <= 10.5f)
                {
                    Console.WriteLine(size);
                }
            }
            Console.WriteLine("\nPRESS ENTER TO CONTINUE\n\n\n");
            Console.ReadLine();

            //============================== CONSOLE APP ASSIGNMENT STEP 200 ==================================
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 200 ==================================");
            //GIVE INSTRUCTIONS
            Console.WriteLine("\nPRESS ENTER TO VIEW THE CONTESTANT LIST OF THE 2020 HILTON FAMILY ANNUAL THUMB-WAR TOURNAMENT");
            Console.ReadLine();
            Console.WriteLine("\tCONTESTANTS:" +
                "\n\n\tVince\n\tDrew" +
                "\n\tKirk\n\tSteph" +
                "\n\tRob\n\tDave" +
                "\n\tJeff\n\tBrighton" +
                "\n\tLily\n\tMaisy");
            //ASK USER TO SEARCH FOR A FINALIST NAME IN THE LIST
            Console.WriteLine("\nNOW TYPE ANY NAME FROM ABOVE " +
                "AND SEE WHICH PLACE (INDEX) EACH CONTESTANT TOOK IN THE TOURNAMENT.\n");
            //INSTANTIATE LIST OF ACTUAL FINALISTS
            List<string> contestant_List = new List<string>() { "referee", "lily", "brighton", "steph", "vince", "drew", "rob", "dave", "jeff", "maisy", "kirk" };

            //SETUP VARIABLE TO CONTROL DO-WHILE LOOP
            bool search = true;

            do
            {
                //STORE USER INPUT AND STORE AS VARIABLE 'inputChoice'
                string inputChoice = Console.ReadLine();
                //CONTROL USER INPUT
                string inputLower = inputChoice.ToLower();

                //ITERATE THROUGH LIST AND SEARCH FOR MATCHING CONTESTANTS
                if (contestant_List.Contains(inputLower))
                {
                    //GIVE USER THE NAME AND PLACE OF THE CONTESTANT IN THE TOURNAMENT (PLACE = INDEX NUMBER).
                    Console.WriteLine("\n\t" + inputLower.ToUpper() + " FINISHED IN THE NUMBER " + contestant_List.IndexOf(inputLower) + " SPOT." +
                        "\n\n\tENTER ANOTHER CONTESTANT NAME OR PRESS 'X' TO MOVE ON\n");
                }
                //OPTION TO EXIT LOOP IF DESIRED
                else if (inputChoice == "x" || inputChoice == "X")
                {
                    //STOP LOOP
                    search = false;
                    Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                }
                else
                {
                    //MESSAGE TELLING USER THAT TEXT IS NOT VALID
                    Console.WriteLine("\nNOT A VALID ENTRY FROM THE LIST. PLEASE CHECK THE SPELLING AND TRY ANOTHER NAME.\n");
                }
            }
            while (search);
            Console.WriteLine("\n\n\n");

            //============================== CONSOLE APP ASSIGNMENT STEP 201 ==================================
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 201 ==================================");
            Console.WriteLine("\nPRESS ENTER TO VIEW A LIST A FEW OF THE PEOPLE I CLIMB WITH");
            Console.ReadLine();
            //MANUALLY PRINT A LIST OF MY CLIMBING PARTNERS TO THE CONSOLE
            Console.WriteLine("\tCLIMBING PARTNERS:" +
                "\n\n\tMike\n\tBrad" +
                "\n\tScott\n\tNathan" +
                "\n\tJohn\n\tWes" +
                "\n\tJason\n\tLuis");
            //INSTANTIATE LIST OF THE LATEST PEOPLE I'VE BEEN CLIMBING WITH
            List<string> partnerList = new List<string>() { "luis", "scott", "john", "mike", "john", "jason", "scott", "brad", "nathan", "wes", "nathan", "wes", "jason", "brad", "mike" };
            //CONVERT TO AN ARRAY FOR LATER SEARCH
            String[] partnerArray = partnerList.ToArray();

            //ASK USER TO SEARCH FOR A FINALIST NAME IN THE LIST
            Console.WriteLine("\nTYPE ANY NAME FROM ABOVE " +
                "AND SEE THE LAST TIME I CLIMBED WITH EACH PARTNER.\n");
            //SETUP VARIABLE TO CONTROL DO-WHILE LOOP
            bool searching = true;

            do
            {
                //STORE USER INPUT AND STORE AS VARIABLE 'inputPartner'
                string partnerInput = Console.ReadLine();
                //CONTROL USER INPUT
                string partnerLower = partnerInput.ToLower();
                //ASSIGN VARIABLES FOR INDEX SEARCHES FROM USER INPUT
                int partnerFirstIndex = Array.IndexOf(partnerArray, partnerLower);
                int partnerLastIndex = Array.LastIndexOf(partnerArray, partnerLower);

                //CONTROL CONDITION FOR INDEX ZERO (PLANS ARE TENTATIVE AND I HAVE NOT CLIMBED WITH LUIS EVER BEFORE)
                if (partnerLower == "luis")
                {
                    Console.WriteLine("\n\tI'VE CLIMBED WITH " + partnerLower.ToUpper() + " EXACTLY... " + partnerFirstIndex + " TIMES BEFORE, BUT WE'VE MADE TENTATIVE PLANS FOR AFTER SCHOOL!" +
                        "\n\n\tTRY SEARCHING ANOTHER NAME, OR PRESS \"X\" TO GO TO THE NEXT DRILL.\n", partnerLower, partnerFirstIndex);
                }
                //MAIN CONDITIONS TO BE MET FOR THE REST OF THE PARTNERS
                else if (partnerArray.Contains(partnerLower))
                {
                    Console.WriteLine("\n\tI CLIMBED WITH " + partnerLower.ToUpper() + " " + partnerFirstIndex + " WEEKS AGO, AND ALSO " + partnerLastIndex + " WEEKS AGO." +
                        "\n\n\tTRY SEARCHING ANOTHER NAME, OR PRESS \"X\" TO GO TO THE NEXT DRILL.\n", partnerLower, partnerFirstIndex, partnerLastIndex);
                }
                //OPTION FOR USER TO EXIT LOOP IF DESIRED
                else if (partnerInput == "x" || partnerInput == "X")
                {
                    //STOP LOOP
                    searching = false;
                    Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                }
                else
                {
                    //MESSAGE TELLING USER THAT TEXT IS NOT VALID
                    Console.WriteLine("\n\tNOT A VALID ENTRY FROM THE LIST. PLEASE CHECK THE SPELLING AND TRY ANOTHER NAME.\n");
                }
            }
            while (searching);
            Console.WriteLine("\n\n\n");

            //============================== CONSOLE APP ASSIGNMENT STEP 202 ==================================
            Console.WriteLine("//============================== CONSOLE APP ASSIGNMENT STEP 202 ==================================");
            Console.WriteLine("\nPRESS ENTER TO SEE THE ADJECTIVES STORED IN MY LIST OF STRINGS.");
            Console.ReadLine();
            Console.WriteLine("ADJECTIVES LIST:" +
                "\n\n\tAWESOME\n\tHAPPY" +
                "\n\tHANGRY\n\tSLOW" +
                "\n\tGOOD\n\tRAINY" +
                "\n\tFUN\n\tSMART");
            Console.WriteLine("\nSOME OF THESE ADJECTIVES OCCUR MORE THAN ONCE IN THE COLLECTION" +
                "\n\nPRESS ENTER TO SEE WHEN EACH ADJECTIVE APPEARS MORE THAN ONCE IN IN THE LIST.");
            Console.ReadLine();
            //INSTANTIATE LIST OF STRINGS 
            List<string> adjectiveList = new List<string>() { "AWESOME", "RAINY", "HAPPY", "HANGRY", "SLOW", "GOOD", "RAINY", "FUN", "HANGRY", "SMART" };
            //CONVERT LIST TO DICTIONARY GIVING EACH ITEM A KVP WITH AN INTEGER AND A STRING
            var adjectives = adjectiveList.Select((x, i) => new { x, i })
                    .ToDictionary(a => a.i, a => a.x);

            foreach (var index in adjectives)
            {
                //CREATE VARIABLES TO GET INDICES AND VALUES FOR THE LIST  
                int id = index.Key;
                string adjective = index.Value;             
                
                //CONDITIONAL STATEMENT FOR ACTION ON SPECIFIC INDICES              
                if (( id == 6) || (id == 8)) 
                {
                    Console.WriteLine("\t" + adjective + "\t HAS ALREADY APPEARED ONCE BEFORE IN THE LIST");
                }
                else
                {
                    Console.WriteLine("\t" + adjective + "\t HAS ONLY APPEARED ONCE");
                }
            }
            Console.Write("\n*** THAT'S FOR SURE MY BEST, AND I THINK I ACTUALLY DID THE ASSIGNMENT RIGHT THIS TIME. HOPEFULLY. :) ***\n\nPRESS ENTER TO EXIT\n\n\n");
            Console.ReadKey(true);
        }
    }
}
