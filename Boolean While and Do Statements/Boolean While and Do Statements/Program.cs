using System;

namespace Boolean_While_and_Do_Statements
{
    class Program
    {
        static void Main()
        {           
            //Converts guessed number into INT then creates BOOL statement for when guessed number is the same as 19//
            Console.WriteLine("Guess a number?");
            int intGuess = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = intGuess == 19;
            //Do statement will execute switch statement once incase the answer is guessed on the first try before looping//
            do 
            {   
                //Switch statement will display special message if specified numbers are guessed, otherwise the default message appears//
                switch (intGuess)
                {
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 32:
                        Console.WriteLine("You guessed 32. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 43:
                        Console.WriteLine("You guessed 43. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 57:
                        Console.WriteLine("You guessed 57. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 65:
                        Console.WriteLine("You guessed 65. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 77:
                        Console.WriteLine("You guessed 77. Try again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 19: //correct message
                        Console.WriteLine("You guessed the number 19. You are correct!");
                        Console.Read();
                        break;
                    default: //default message
                        Console.WriteLine("You are wrong. Try Again.");
                        Console.WriteLine("Guess a number?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }

                
            }
            //After do statement is applied once then while loop commenses//
            while (!isGuessed);
            Console.Read();

        }

    }
}
