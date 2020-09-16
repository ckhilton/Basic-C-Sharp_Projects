using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("\nPerson 1:\nHourly Rate?");
            float p1Hourly = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float p1Hours = float.Parse(Console.ReadLine());

            Console.WriteLine("\nPerson 2:\nHourly Rate?");
            float p2Hourly = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float p2Hours = float.Parse(Console.ReadLine());

            Console.WriteLine("\nAnnual salary of Person 1:");
            //MATH FOR ANNUAL SALARY
            float p1Salary = p1Hourly * p1Hours * 52;
            Console.WriteLine("$" + p1Salary);

            Console.WriteLine("\nAnnual salary of Person 2:");
            //MATH FOR ANNUAL SALARY
            float p2Salary = p2Hourly * p2Hours * 52;
            Console.WriteLine("$" + p2Salary);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            //BOOLEAN COMPARISON
            Console.WriteLine(p1Salary > p2Salary);

            Console.ReadLine();
        }
    }
}
