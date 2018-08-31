using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingClassExercise
{
    class Moth
    {

        public int age { get; set; }
        //public int petTotal { get; set; }

        public int Addz(string num1, string num2)
        {
            int mathResult = Convert.ToInt32(num1) + Convert.ToInt32(num2);            
            return mathResult;
        }

        public int Subby(decimal num1, decimal num2)
        {
            int mathResult = Convert.ToInt32(num1) - Convert.ToInt32(num2); //Convert decimal answers into int            
            return mathResult;
        }

        public int Multy(int num1, int num2)
        {
            var mathResult = num1 * num2;            
            return mathResult;
        }
        public int Nothing(int num1)
        {
            var mathResult = num1;            
            return mathResult;
        }
    }
}