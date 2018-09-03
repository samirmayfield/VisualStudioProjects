using System;

class Program
{
    
    static void Main()
    {
        try
        {
            
            Console.WriteLine("Please enter a day of the week");
            string today = Console.ReadLine(); 

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), today.ToUpper()); //Converts string to enum data type, also converts string to uppercase so it can be matched properly           
            Console.ReadLine();
           
        }
        catch
        {
            Console.WriteLine("Please enter an actual day of the week please");
            Console.ReadLine();
        }
    }
    public enum DayOfWeek
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }


}