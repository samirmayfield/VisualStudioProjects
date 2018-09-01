using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Program
    {
        static void Main(string[] args)
        {


            Employee chuck = new Employee();  //Creating object chuck from employee class         //Instantiating
            Employee dale = new Employee();   //Creating object dale from employee class


            chuck.ID = 40; //setting value to property ID for object chuck that was defined from the employee class
            dale.ID = 50;  //setting value to property ID for object dale that was defined from the employee class

            //Using if else statement to check if objects are the same
            if (chuck == dale)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are NOT the same");
            }





            Console.ReadLine();
        }
    }
}