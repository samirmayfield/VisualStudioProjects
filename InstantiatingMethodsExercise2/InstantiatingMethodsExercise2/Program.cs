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
            int number2 = 12;
            decimal decimal1 = 1.343m;
            decimal decimal2 = 5.353m;
            string int1 = "3";
            string int2 = "5";

            //Passing newly created int's through the methods created on on moth class, also labeling int placements as labeled in moth class methods//

            Dale.Multy(num1: number1, num2: number2);     //Passes two ints from list
            Dale.Nothing(num1: number2);                  //Passing int to nothing method and printing to screen without any changes to the int/
            Dale.Subby(num1: decimal1, num2: decimal2);    //Passing in decimal, then printing int to screen
            Dale.Addz(num1: int1, num2: int2);      //Exercise only asking to print number without the math operation



            Console.ReadLine();

        }
    }
}