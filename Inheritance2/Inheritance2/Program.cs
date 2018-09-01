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


            IQuittable newEmployee = new Employee();  //Polymorphic



            newEmployee.Quit();


            Console.ReadLine();
        }
    }
}
