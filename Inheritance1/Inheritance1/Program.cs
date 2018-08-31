using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Employee newEmployee = new Employee();
            
            
            newEmployee.firstName = "Sample";
            newEmployee.lastName = "Student";
            newEmployee.SayName();


            Console.ReadLine();
        }
    }
}
