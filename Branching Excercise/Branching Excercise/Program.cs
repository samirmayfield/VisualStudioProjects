using System;

namespace Branching_Excercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter a package weight");
            string packageWeight = Console.ReadLine();
            double myWeight = Int32.Parse(packageWeight);
            if (myWeight < 50)
            {
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
                if (totalDimensions < 50)
                {
                    double priceResult = totalDimensions * myWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceResult);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            

        }
    }
}
