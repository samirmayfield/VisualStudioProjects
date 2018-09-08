using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageToYearBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            try
            {
                int age = (Convert.ToInt32(Console.ReadLine()));
                if (age < 1) throw new ArgumentOutOfRangeException();
                DateTime bday = DateTime.Now.AddYears(-age);
                Console.WriteLine("You were born in " + bday.Year);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number must be greater than 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }
            Console.ReadLine();
        }
    }
}
