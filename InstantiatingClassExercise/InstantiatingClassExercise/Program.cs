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

            Moth Dale = new Moth(); //Instantiating Class Moth

            //Dale.age = 43; 
            //Dale.petTotal = 12;

            int number1 = 4;
            int number2 = 3;

            Dale.Multy(number1, number2); //Passing newly created int's through the methods created on on moth class//
            Dale.Subby(number1, number2);
            Dale.Addz(number1, number2);

            ;

            Console.ReadLine();            
            
        }
    }
}