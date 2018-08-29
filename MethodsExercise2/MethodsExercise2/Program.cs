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
            Intlist intlist = new Intlist();


            foreach (Item item in intlist.Items)
            {
                //doing math operation on first int then displaying second int to console
                int myInt = item.numOne * 30;
                Console.WriteLine(item.numTwo);
            }
            
            Console.ReadLine();
        }        
    }
}