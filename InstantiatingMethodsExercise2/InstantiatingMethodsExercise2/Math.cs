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

        public void Addz(string num1, string num2)
        {
            int mathResult = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Console.WriteLine(mathResult);
        }

        public void Subby(decimal num1, decimal num2)
        {
            int mathResult = Convert.ToInt32(num1) - Convert.ToInt32(num2); //Convert decimal answers into int
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