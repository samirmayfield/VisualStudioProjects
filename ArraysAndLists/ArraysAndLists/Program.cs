using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Notice System.Collections.Generic library is being accessed for list commands//

    class Program
    {
        static void Main()
        {        
        //Creating a list//
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Add(20);
        intList.Remove(10); 
        //Prints only the first object in the list, which is 4//
        Console.WriteLine(intList[0]);
        Console.ReadLine();        
        //Creating an array//
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;
        //Another way of creating an array without specifying how many objects will exist within the array//
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Prints 4th object integar contained in both arrays which is 200//
        Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray1[3]);
        Console.ReadLine();
        }
    }

