using Inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Employee
    {
        public int ID { get; set; } //setting int property called ID
        
        
        //overloading operator so later we can pass through the objects without needing to declare their ID as they are defined here 
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID;
        }
    }
}