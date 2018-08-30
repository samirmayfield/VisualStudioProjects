using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingClassExercise
{
    class Moth
    {

      

        public void Addz(int num1, int num2)
        {
            var mathResult = num1 + num2;
            Console.WriteLine(mathResult);
        }

        public void Subby(int num1, int num2 = 1)
        {
            var mathResult = num1 - num2; 
            Console.WriteLine(mathResult);
        }

        public void Multy(int num1, int num2)
        {
            var mathResult = num1 * num2;
            Console.WriteLine(mathResult);
        }
        public void Nothing(int num1)
        {
            var mathResult = num1;
            Console.WriteLine(mathResult);
        }
    }
}