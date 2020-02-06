using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    class Validator
    {

        public static string ValidateUserInput()
        {
            bool validInput = true;
            while (validInput)
            {
                string userInput = GetUserInput("Rock, Paper, or Scissors? (r/p/s)");
                validInput = false;

                switch (userInput)
                {
                    case "r":
                        return userInput;
                    case "p":
                        return userInput;
                    case "s":
                        return userInput;
                    default:
                        validInput = true;
                        Console.WriteLine("Please enter a valid selection (r, p, or s)");
                        break;
                }
            }
            return "Invalid Input";
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
