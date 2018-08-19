using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    

    static void Main()
    {

        //String list for drinks//
        List<string> stringList = new List<string>();
        stringList.Add("Water");
        stringList.Add("Juice");
        stringList.Add("Beer");
        stringList.Add("Milk");
        //INT array for index//
        int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //String array for fruits//
        string[] fruitArray = new string[] { "Apple", "Orange", "Banana", "Peach", "Pear" };
        Console.WriteLine("Welcome to this fruit and drink indexing browser!");
        Console.WriteLine("\n\nPlease enter index number between 1-9 to display a list of fruits and drinks");
        Console.WriteLine("You may also enter the name of your fruit or drink to display the corresponding index");
        string yourAnswer = Console.ReadLine();
        //Converts answer to uppercase so it can be read properly//
        yourAnswer = yourAnswer.ToUpper();
        //Created bool to pass through while loop//    
        bool stringAnswer = yourAnswer == "" || yourAnswer == "APPLE" || yourAnswer == "ORANGE" || yourAnswer == "BANANA" || yourAnswer == "PEACH" || yourAnswer == "PEAR" || yourAnswer == "WATER" || yourAnswer == "JUICE" || yourAnswer == "BEER" || yourAnswer == "MILK" ||yourAnswer == "1" || yourAnswer == "2" || yourAnswer == "3" || yourAnswer == "4" || yourAnswer == "5" || yourAnswer == "6" || yourAnswer == "7" || yourAnswer == "8" || yourAnswer == "9";
        do
        {

            switch (yourAnswer)
            {
                case "1":
                    Console.WriteLine("You have selected " + fruitArray[0]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper(); //uppercase answer after every reentry
                    break;
                case "2":                
                    Console.WriteLine("You have selected " + fruitArray[1]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "3":                    
                    Console.WriteLine("You have selected " + fruitArray[2]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "4":                   
                    Console.WriteLine("You have selected " + fruitArray[3]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "5":    
                    Console.WriteLine("You have selected " + fruitArray[4]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "6":
                    Console.WriteLine("You have selected " + stringList[0]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "7":
                    Console.WriteLine("You have selected " + stringList[1]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "8":
                    Console.WriteLine("You have selected " + stringList[2]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "9":
                    Console.WriteLine("You have selected " + stringList[3]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "APPLE":
                    Console.WriteLine("You have selected Apple located at index " + numArray[0]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "ORANGE":
                    Console.WriteLine("You have selected Orange located at index " + numArray[1]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "BANANA":
                    Console.WriteLine("You have selected Banana located at index " + numArray[2]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "PEACH":
                    Console.WriteLine("You have selected Peach located at index " + numArray[3]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "PEAR":
                    Console.WriteLine("You have selected Pear located at index " + numArray[4]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "WATER":
                    Console.WriteLine("You have selected Water located at index " + numArray[5]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "JUICE":
                    Console.WriteLine("You have selected Juice located at index " + numArray[6]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "BEER":
                    Console.WriteLine("You have selected Beer located at index " + numArray[7]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "MILK":
                    Console.WriteLine("You have selected Milk located at index " + numArray[8]);
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;
                case "":
                    Console.WriteLine("You have not entered anything. Program will stop execution. Please restart program.");
                    Console.ReadLine();
                    return;
                                       
                default: //default if readline() cannot process request//
                    Console.WriteLine("Im sorry we couldnt process your request! Please enter an index number between 1-9 to see our selections or type the name of a fruit we carry to see what index number it is located at!");
                    yourAnswer = Console.ReadLine();
                    yourAnswer = yourAnswer.ToUpper();
                    break;

            }
            
        }
        while (stringAnswer);
        Console.ReadLine();
    }
}

