using System;

namespace Branching_Excercise
{
    class Program
    {
        static void Main()
        {
            //Strings answer then converts to double//
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter a package weight");
            string packageWeight = Console.ReadLine();
            double myWeight = Int32.Parse(packageWeight);
            //If weight is less then 50 proceed//
            if (myWeight < 50)
            {
                //Strings answer then converts to double//
                Console.WriteLine("Please enter the package width");
                string packageWidth = Console.ReadLine();
                double myWidth = Int32.Parse(packageWidth);
                Console.WriteLine("Please enter the package height");
                string packageHeight = Console.ReadLine();
                double myHeight = Int32.Parse(packageHeight);
                Console.WriteLine("Please enter the package length");
                string packageLength = Console.ReadLine();
                double myLength = Int32.Parse(packageLength);
                double totalDimensions = myLength + myHeight + myWidth;
                //If dimensions total less than 50 proceed//
                if (totalDimensions < 50)
                {
                    double priceResult = totalDimensions * myWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceResult);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();

                }
                //If dimensions total 50 or more then do not proceed//
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                
            }
            //If weight is 50 or greater then do not proveed//
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            

        }
    }
}
