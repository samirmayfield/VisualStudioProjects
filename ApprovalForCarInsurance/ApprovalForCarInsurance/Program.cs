using System;

namespace ApprovalForCarInsurance
{
    class Program
    {
        static void Main()
        {
            //Checks age then converts to INT//
            Console.WriteLine("What is your age?");
            string myAge = Console.ReadLine();
            int ageInt = Int32.Parse(myAge); 
            //Checks DUI record then converts to BOOL//
            Console.WriteLine("Have you ever had a DUI? (answer with \"true\" or \"false\")");
            string myDui = Console.ReadLine();
            bool duiBool = bool.Parse(Convert.ToString(myDui));      
            //Checks speeding tickets then converts to INT//
            Console.WriteLine("How many speeding tickets do you have?");
            string myTickets = Console.ReadLine();
            int ticketsInt = Int32.Parse(myTickets);
            //Checks data collected and prints true or false qualification to console//
            Console.WriteLine("Qualified?");
            bool trueFalse = ageInt > 15 && duiBool == false && ticketsInt <= 3;
            Console.WriteLine(trueFalse);
            Console.ReadLine();
        }
    }
}
