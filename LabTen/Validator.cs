using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Validator
    {
        public static double IsValid()
        {
            while (true)
            {
                try
                {
                    //Prompt for user to enter a radius. Data is validated to ensure the data entered matches the expected data type
                    Console.WriteLine("Welcome to the Circle Tester");
                    Console.WriteLine("Enter Radius:");
                    double input = double.Parse(Console.ReadLine());
                    return input;
                }
                catch(FormatException)
                {
                    Console.WriteLine("That is not a valid entry. Please try again:");
                }
            }
        }
    }
}
