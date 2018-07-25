using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1 income survey//
            Console.WriteLine("Person 1");
            Console.WriteLine("How much money do you make hourly?");
            string yourHourlyWage = Console.ReadLine();
            int yourHourlyWage2 = Int32.Parse(yourHourlyWage);
            Console.WriteLine("How many hours have you worked this week");
            string hoursPerWeek = Console.ReadLine();
            int hoursPerWeek2 = Int32.Parse(hoursPerWeek);  
            //Person 2 income survey//
            Console.WriteLine("Person 2");
            Console.WriteLine("How much money do you make hourly?");
            string yourHourlyWageTwo = Console.ReadLine();
            int yourHourlyWageTwo2 = Int32.Parse(yourHourlyWageTwo);
            Console.WriteLine("How many hours have you worked this week");
            string hoursPerWeekTwo = Console.ReadLine();
            int hoursPerWeekTwo2 = Int32.Parse(hoursPerWeekTwo);
            //Person 1 Annual income calculation//
            int yearlySalary = yourHourlyWage2 * hoursPerWeek2 * 52;
            Console.Write("Annual income for person 1 is ");
            Console.WriteLine(yearlySalary);         
            //Person 2 Annual income calculation//
            int yearlySalaryTwo = yourHourlyWageTwo2 * hoursPerWeekTwo2 * 52;
            Console.Write("Annual income for person 2 is ");
            Console.WriteLine(yearlySalaryTwo);
            //Comparing person 1 with person 2//
            bool trueFalse = yearlySalary > yearlySalaryTwo;           
            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(trueFalse);



           
            Console.ReadLine();




        }
    }
}
