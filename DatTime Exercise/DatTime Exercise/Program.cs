using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        var time = DateTime.Now;       
        Console.WriteLine("Please enter a number");
        int answer = Convert.ToInt32(Console.ReadLine());        
        DateTime currentTime = DateTime.Now;
        DateTime twoHoursLater = currentTime.AddHours(answer);
        Console.WriteLine(string.Format("{0} {1}", currentTime, twoHoursLater));
        Console.ReadLine();
    }
}
