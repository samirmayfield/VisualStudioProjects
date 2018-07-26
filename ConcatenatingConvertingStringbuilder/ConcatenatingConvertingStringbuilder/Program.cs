using System;
using System.Text;

namespace ConcatenatingConvertingStringbuilder
{
    class Program
    {
        static void Main()
        {
            string stringOne = "Hello, my name is ";
            string stringTwo = "Samir, ";
            string stringThree = "it is nice to make your acquaintance!";
            string allStrings = stringOne + stringTwo + stringThree;
            string upperCase = allStrings.ToUpper();
            Console.WriteLine(upperCase);
            //Use AppendLine//
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("One");
            builder.AppendLine();
            builder.AppendLine("Two").AppendLine("Three");

            //Display//
            Console.Write(builder);

            //AppendLine uses \r\n sequences//
            Console.WriteLine(builder.ToString().Contains("\r\n"));
            Console.ReadLine();
        }
       
    }

    
}
