using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            string answer = Convert.ToString(Console.ReadLine());
            File.WriteAllText("C:\\Users\\Public\\Log.txt", answer);
            string textFile = File.ReadAllText("C:\\Users\\Public\\Log.txt");
            Console.WriteLine(textFile);
            Console.ReadLine();
        }
    }
}