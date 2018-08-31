using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingClassExercise
{
    class Moth
    {

        public void Divide(double num1,out double anotherAnswer, double num2 = 2)
        {
            anotherAnswer = 6.7;
            double mathResult = num1 / num2;
            Console.WriteLine(mathResult);

            
        }        
    }
}
