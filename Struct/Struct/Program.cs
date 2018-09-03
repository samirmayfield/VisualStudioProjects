using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.amount = Convert.ToDecimal(12345.65789);

            Console.WriteLine(number.amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal amount { get; set; } 
        }
    }
}
