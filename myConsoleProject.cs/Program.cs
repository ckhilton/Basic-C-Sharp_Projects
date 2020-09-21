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
            //Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 200 =====");
            ////GIVE INSTRUCTIONS
            //Console.WriteLine("\nPRESS ENTER TO VIEW THE CONTESTANT LIST OF THE 2020 HILTON FAMILY ANNUAL THUMB-WAR TOURNAMENT");
            //Console.ReadLine();
            //Console.WriteLine("\tCONTESTANTS:" +
            //    "\n\n\tVince\n\tDrew" +
            //    "\n\tKirk\n\tSteph" +
            //    "\n\tRob\n\tDave" +
            //    "\n\tJeff\n\tBrighton" +
            //    "\n\tLily\n\tMaisy");
            ////ASK USER TO SEARCH FOR A FINALIST NAME IN THE LIST
            //Console.WriteLine("\nNOW TYPE ANY NAME FROM ABOVE " +
            //    "AND SEE WHICH PLACE (INDEX) EACH CONTESTANT TOOK IN THE TOURNAMENT.\n");
            ////INSTANTIATE LIST OF ACTUAL FINALISTS
            //List<string> contestant_List = new List<string>() { "referee", "lily", "brighton", "steph", "vince", "drew", "rob", "dave", "jeff", "maisy", "kirk" };

            ////SETUP VARIABLE TO CONTROL DO-WHILE LOOP
            //bool search = true;

            //do
            //{
            //    //STORE USER INPUT AND STORE AS VARIABLE 'inputChoice'
            //    string inputChoice = Console.ReadLine();
            //    //CONTROL USER INPUT
            //    string inputLower = inputChoice.ToLower();

            //    //ITERATE THROUGH LIST AND SEARCH FOR MATCHING CONTESTANTS
            //    if (contestant_List.Contains(inputLower))
            //    {
            //        //GIVE USER THE NAME AND PLACE OF THE CONTESTANT IN THE TOURNAMENT (PLACE = INDEX NUMBER).
            //        Console.WriteLine("\n\t" + inputLower.ToUpper() + " FINISHED IN THE NUMBER " + contestant_List.IndexOf(inputLower) + " SPOT." +
            //            "\n\n\tENTER ANOTHER CONTESTANT NAME OR PRESS 'X' TO MOVE ON\n");
            //    }
            //    //OPTION TO EXIT LOOP IF DESIRED
            //    else if (inputChoice == "x")
            //    {
            //        //STOP LOOP
            //        search = false;
            //    }
            //    else
            //    {
            //        //MESSAGE TELLING USER THAT TEXT IS NOT VALID
            //        Console.WriteLine("\nNOT A VALID ENTRY FROM THE LIST. PLEASE CHECK THE SPELLING AND TRY ANOTHER NAME.\n");
            //    }               
            //}
            //while (search);

            //============= CONSOLE APP ASSSIGNMENT STEP 201 ====================
            Console.WriteLine("//===== CONSOLE APP ASSIGNMENT STEP 201 =====");
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
            Console.WriteLine("\nNOW TYPE ANY NAME FROM ABOVE " +
                "AND SEE HOW MANY TIMES AGO I CLIMBED WITH EACH PARTNER.\n");
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
                else if (partnerInput == "x") 
                {
                    //STOP LOOP
                    searching = false;
                }               
                else
                {
                    //MESSAGE TELLING USER THAT TEXT IS NOT VALID
                    Console.WriteLine("\n\tNOT A VALID ENTRY FROM THE LIST. PLEASE CHECK THE SPELLING AND TRY ANOTHER NAME.\n");
                }               
            }
            while (searching);

            Console.ReadLine();
        }
    }
}






//do
//{
//    if (partnerList.Contains(Console.ReadLine()))
//    {
//        switch (partnerLower)
//        {
//            case "Luis":
//                Console.WriteLine("\nI JUST MET " + partnerList.toUpper() + "  AND I HAVEN'T CLIMBED WITH HIM YET, BUT WE HOPE TO CLIMB TOGETHER SOON.");
//                partnerLower = Console.ReadLine();
//                break;
//            case "scott":
//                //if (partnerLower.Contains("scott")
//                Console.WriteLine("\nI CLIMBED WITH " + partnerList.Contains("scott") + " 1 WEEK AGO AND 4 WEEKS AGO. SEARCH ANOTHER NAME.");
//                partnerLower = Console.ReadLine();
//                break;
//            case "mike":
//                Console.WriteLine("\nI CLIMBED WITH " + partnerLower.ToUpper() + " 2 WEEKS AGO AND 12 WEEKS AGO.");
//                partnerLower = Console.ReadLine();
//                break;
//            case "jason":
//                Console.WriteLine("\nI CLIMBED WITH " + partnerLower.ToUpper() + "3 WEEKS AGO AND 10 WEEKS AGO.");
//                partnerLower = Console.ReadLine();
//                break;
//            case "brad":
//                Console.WriteLine("\nI CLIMBED WITH " + partnerLower.ToUpper() + " 4 WEEKS AGO AND 11 WEEKS AGO.");
//                partnerLower = Console.ReadLine();
//                break;
//            case "nathan":
//                Console.WriteLine("\nI CLIMBED WITH " + partnerLower.ToUpper() + " 5 WEEKS AGO AND 7 WEEKS AGO.");
//                partnerLower = Console.ReadLine();
//                break;
//            default:
//                Console.WriteLine("\nSORRY, THAT IS NOT A VALID ENTRY. PLEASE CHECK YOUR SPELLING AND TRY AGAIN.");
//                partnerLower = Console.ReadLine();
//                break;
//        }
//    }
//    while (searching) ;



////SETUP DO WHILE LOOP
//bool searching = true;








//////store user input and store as variable 'inputpartner'
//string inputPartner = Console.ReadLine();
//////CONTROL USER INPUT
////string partnerLower = inputPartner.ToLower();

//int number = Array.IndexOf(partnerArray, inputPartner);

//foreach (string partner in partnerArray)
//{
//    if (partner == inputPartner)
//    {

//        Console.WriteLine(number);
//    }
//}






//bool find = true;

//do
//{
//    //STORE USER INPUT AND STORE AS VARIABLE 'inputPartner'
//    string inputPartner = Console.ReadLine();
//    //CONTROL USER INPUT
//    string partnerLower = inputPartner.ToLower();

//    //BRANCHING CONDITIONS TO BE MET
//    //if (partnerArray.Contains(partnerLower))
//    //{
//    //string[] partnerArray = partnerList.ToArray();

//    //int i = 0;

//    //int indexOfChoice = Convert.ToInt32(partnerList.IndexOf(partnerLower));

//    //int[] index = new int[partnerArray.Length];

//    //for (int partner in partnerArray)
//    //{
//    for (int i = 0; i < partnerArray.Count(); i++)
//    {
//        foreach (int partner in partnerArray[i])
//        {
//            if ()


//            }


//            //GIVE USER THE NAME AND PLACE OF THE CONTESTANT IN THE TOURNAMENT (PLACE = INDEX NUMBER)
//            Console.WriteLine("\n\t" + partnerLower.ToUpper() + " WENT CLIMBING WITH ME THESE TIMES: " + partnerArray[i] +


//            "\n\n\tENTER ANOTHER PARTNER NAME OR PRESS 'X' TO MOVE ON ");
//        }

//    }







//    //}
//    //OPTION TO EXIT LOOP IF DESIRED
//    //else if (inputPartner == "x")
//    //{
//    //    //STOP LOOP
//    //    find = false;
//    //}
//    //else
//    //{
//    //    Console.WriteLine("\nNOT A VALID ENTRY FROM THE LIST. PLEASE CHECK THE SPELLING AND TRY ANOTHER NAME.\n");
//    //}

//}
//while (find);



////var listClimbs = Enumerable.Range(0, partnerList.Count)
////    .Where(i => partnerList[i] == partnerLower)
////    .ToList();

//{
//    switch (contestant)
//    {
//        case string 'Kirk':



//    }
//}

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

