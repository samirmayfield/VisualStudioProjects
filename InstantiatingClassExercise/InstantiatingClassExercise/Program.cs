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

            //Dale.age = 43; 
            //Dale.petTotal = 12;

            int number1 = 4;
            int number2 = 3;

            //Passing newly created int's through the methods created on on moth class, also labeling int placements as labeled in moth class methods//
            //Dale.Multy(num1: number1, num2: number2);     //Exercise only asking to print number without the math operation
            //Dale.Subby(num1: number1, num2: number2);     //Exercise only asking to print number without the math operation
            //Dale.Addz(num1: number1, num2: number2);      //Exercise only asking to print number without the math operation

            Dale.Nothing(num1: number2); //Printing number2, which is 3, to the screen from the nothing method it was passed through//
            
            Console.ReadLine();            
            
        }
    }
}