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
            //DEFINE STRING VARIABLES
            string str1 = "Hello, ";
            string str2 = "my name is ";
            string str3 = "Kirk.";
            string sentence = str1 + str2 + str3;

            //CONCATENATE THREE STRINGS
            Console.WriteLine("//CONCATENATE THREE STRINGS");
            Console.WriteLine("\n\t" + sentence);

            string upperSentence = sentence.ToUpper();

            //CONVERT A STRING TO UPPERCASE
            Console.WriteLine("\n//CONVERT A STRING TO UPPERCASE");
            Console.WriteLine("\n\t" + upperSentence);

            //BUILD A STRINGBUILDER AND ADD SENTENCES TO FORM A PARAGRAPH
            Console.WriteLine("\n//CREATE STRINGBUILDER AND BUILD PARAGRAPH");
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("\n\tHello, my name is Kirk. ");
            paragraph.Append("I like to climb. ");
            paragraph.Append("I also like software development. ");
            paragraph.Append("I'm loving life and I'm happy to be alive! ");

            //PRINT PARAGRAPH TO CONSOLE
            Console.WriteLine(paragraph);

            Console.ReadLine();
        }
    }
}
