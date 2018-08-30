using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingClassExercise
{
    class Moth
    {

        //public int age { get; set; }
        //public int petTotal { get; set; }

        public void Addz(int num1, int num2)
        {
           var mathResult = num1 + num2;
           Console.WriteLine(mathResult);
        }

        public void Subby(int num1, int num2)
        {
            var mathResult = num1 - num2;
            Console.WriteLine(mathResult);
        }

        public void Multy(int num1, int num2)
        {
            var mathResult = num1 * num2;
            Console.WriteLine(mathResult);
        }
    }
}
