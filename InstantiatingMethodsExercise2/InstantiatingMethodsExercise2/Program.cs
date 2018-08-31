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
            int mathResult3 = Dale.Addz(int1, int2);
            int mathResult2 = Dale.Subby(decimal1, decimal2);
            int mathResult = Dale.Multy(number1, number2);
            int mathResult4 = Dale.Nothing(number2);

            

            

            Console.WriteLine(mathResult);
            Console.WriteLine(mathResult4);
            Console.WriteLine(mathResult2);
            Console.WriteLine(mathResult3);

            Console.ReadLine();

        }
    }
}