using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCircles = 0;    //variable and starting point to count the number of times the while loop is ran
            bool run = true;
            while (run == true)
            {
                Circle radCircle = new Circle(Validator.IsValid()); //variable for Circle class for equations and validator class for validation

                Console.WriteLine($"Circuference:{radCircle.CalculateCircumference()}");
                Console.WriteLine($"Formatted circumference:{radCircle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {radCircle.CalculateArea()}");
                Console.WriteLine($"Formatted Area: {radCircle.CalculateFormattedArea()}");

                numberOfCircles++;  //Counts the number of times the while loop is ran
                run = Continue(numberOfCircles);    //Connects while loop with Continue method and passes the value for the number of times the while loop is ran
            }
        }

        public static bool Continue(int numberOfCircles)
        {
            //Allows user to continue creating circles or exit program. Response will also be validated
            Console.WriteLine("Would like to create another circle? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool run;

            if(userContinue == "y")
            {
                run = true;
            }
            else if(userContinue == "n")
            {
                Console.WriteLine("Goodbye. You created {0} Circle object(s)", + numberOfCircles);
                run = false;
            }
            else
            {
                Console.WriteLine("That is an invalid response. Please try again:(y/n)");
                run = Continue(numberOfCircles);
            }
            return run;
        }
    }
}
