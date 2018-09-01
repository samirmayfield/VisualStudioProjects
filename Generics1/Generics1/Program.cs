using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Jack = new Employee<string>();
            Employee<int> Jill = new Employee<int>();

            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();

            stringList.Add("Jill");
            stringList.Add("Jack");
            intList.Add(8);
            intList.Add(9);

            Jack.things = stringList;
            Jill.things = intList;
            

        }
    }
}
