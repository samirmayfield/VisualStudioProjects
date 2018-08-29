using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //creating list of doubles//
                List<double> numbers = new List<double>();
                double[] list = new double[] { 1, 2, 3 };
                numbers.AddRange(list);
                //requesting integar//
                Console.WriteLine("Pick a number.");
                double numberOne = Convert.ToInt32(Console.ReadLine());
                //printing result to console//
                Console.WriteLine("Dividing the three sets of integars from list...");
                double list1 = numberOne / list[0];
                double list2 = numberOne / list[1];
                double list3 = numberOne / list[2];
                Console.WriteLine(list1);
                Console.WriteLine(list2);
                Console.WriteLine(list3);
            }
            //catch format exception and write to console//
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            //catch divided by zerp exception and write to console//
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            //catch general exception and write to console
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //the last thing//
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }

    }
}
