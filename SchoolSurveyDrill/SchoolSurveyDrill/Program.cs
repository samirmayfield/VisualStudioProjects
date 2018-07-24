using System;



class Program
{
    static void Main()
    {


        Console.WriteLine("\nThe Tech Academy");
        Console.WriteLine("\nStudent Daily Report");
        Console.WriteLine("\n\n\n\nWhat course are you on?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        string askHelp = Console.ReadLine();
        bool trueFalse = bool.Parse(Convert.ToString(askHelp));
        Console.WriteLine("Were there any positive experiences you would like to share? Please be specific.");
        string yourExperience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string yourFeedBack = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();

        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");



        Console.ReadLine();


    }
}

