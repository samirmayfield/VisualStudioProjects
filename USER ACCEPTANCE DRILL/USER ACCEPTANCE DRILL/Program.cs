using System;



class Program
{
    static void Main()
    {



        Console.WriteLine("\n\n\nEnter a number and watch it multiply by 50");
        string inputNum = Console.ReadLine();
        int answerNum = Int32.Parse(inputNum);        
        int yourAnswer = 50 * answerNum;
        Console.WriteLine(yourAnswer);

        Console.WriteLine("Enter a number and watch it add 25");
        string inputNum1 = Console.ReadLine();
        int answerNum1 = Int32.Parse(inputNum1);
        int yourAnswer1 = 25 + answerNum1;
        Console.WriteLine(yourAnswer1);

        Console.WriteLine("Enter a number and watch it divide by 12.5");
        string inputNum2 = Console.ReadLine();
        int answerNum2 = Int32.Parse(inputNum2);
        double yourAnswer2 = answerNum2 / 12.5;
        Console.WriteLine(yourAnswer2);

        Console.WriteLine("Enter a number to check if it is greater than 50");
        string inputNum3 = Console.ReadLine();
        int answerNum3 = Int32.Parse(inputNum3);
        bool yourAnswer3 = answerNum3 > 50;
        Console.WriteLine(yourAnswer3);

        Console.WriteLine("Enter a number to divide it by 7 and tell you the remainder");
        string inputNum4 = Console.ReadLine();
        int answerNum4 = Int32.Parse(inputNum4);
        int yourAnswer4 = answerNum4 % 7;
        Console.WriteLine(yourAnswer4);





        Console.ReadLine();


    }
}

