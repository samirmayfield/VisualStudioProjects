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
            Moth Dale = new Moth(); //Instantiating Class Moth//  
            
            Console.WriteLine("Enter an integar");
            
            double myAnswer1 = Convert.ToDouble(Console.ReadLine());
            Dale.Divide(myAnswer1, out double passValue);
            
            Console.WriteLine(anotherAnswer);
            Console.ReadLine();
        }
    }
}