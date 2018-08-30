using InstantiatingClassExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Moth Dale = new Moth(); //Instantiating Class Moth//            

            int number1 = 4;
            int number2 = 12;            

            //Passing newly created int's through the methods created on on moth class, also labeling int placements as labeled in moth class methods//
            Dale.Multy(num1: number1, num2: number2);     //Passes two ints from list
            Console.WriteLine("Enter an integar");
            int myAnswer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integar if you wish, or not, no worries.");
            
            if (Console.ReadLine() != "")
            {
               int myAnswer2 = Convert.ToInt32(Console.ReadLine());
                Dale.Subby(num1: myAnswer1, num2: myAnswer2); 

            }
            else
            {
                Dale.Subby(num1: myAnswer1);
            }
            Console.ReadLine();
        }
    }
}