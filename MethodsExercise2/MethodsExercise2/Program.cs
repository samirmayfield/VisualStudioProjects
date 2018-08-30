using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math problem1 = new Math();

            problem1.numOne = 5;
            problem1.numTwo = 3;

            problem1.Addition();






            /*
            Random rnd = new Random();
           

            Intlist intlist = new Intlist(); //instantiating new object            
            intlist = Random(mylist: intlist, times: 3);

            foreach (Item item in intlist.Items)
            {
                //math operation on first int then displaying second int to console
                int myInt = item.numOne * 30;
                Console.WriteLine(item.numTwo);
            }
            */
            Console.ReadLine();
        }

        
       
    }
}