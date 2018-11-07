using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee() { First = "joe", Last = "smith", Id = 1 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 2 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 3 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 4 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 5 });
            employee.Add(new Employee() { First = "joe", Last = "black", Id = 6 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 7 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 8 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 9 });
            employee.Add(new Employee() { First = "bob", Last = "smith", Id = 10 });


            //List<Employee> joeList = new List<Employee>();

            //foreach (Employee name in employee)
            //{
            //    if (name.First == "joe")
            //    {
            //        joeList.Add(name);
            //        Console.WriteLine(name.First + " " + name.Last + " " + name.Id);

            //    }
            //}

            //List<Employee> joeList2 = employee.Where(x => x.First == "joe").ToList();

            //foreach (Employee names in joeList2)
            //{
            //    Console.WriteLine(names.First + " " + names.Last + " " + names.Id);
            //}

            List<Employee> joeList2 = employee.Where(x => x.Id > 5).ToList();

            foreach (Employee names in joeList2)
            {
                Console.WriteLine(names.First + " " + names.Last + " " + names.Id);
            }
          



            Console.ReadLine();



            

        }
    }
}
