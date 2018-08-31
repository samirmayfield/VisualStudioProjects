using InstantiatingClassExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsExercise4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Moth Dale = new Moth(); //Instantiating Class Moth//  
            
            Console.WriteLine("Enter an integar");
            string newString;
            double myAnswer1 = Convert.ToDouble(Console.ReadLine());
            //double mathResult = Dale.Dividing(myAnswer1, out newString );
            double mathResult = Moth.Dividing(myAnswer1, out newString);
            Console.WriteLine("Your math result is " + mathResult);
            Console.WriteLine("I want to let you know..." + newString);


            Console.ReadLine();
        }
    }
}