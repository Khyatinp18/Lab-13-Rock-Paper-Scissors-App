using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    class RoshamboApp
    {
        public void StartPlay()
        {

            string yourName =  GetUserName();

            bool wantToContinue = true;

            while (wantToContinue)
            {
                ChoosePlayer(yourName);
                wantToContinue = KeepGoing("Player again? (y/n)?","y", "n" );
                    
            }
            Console.WriteLine("Thank you for playing! Good Bye!");
            


        }

        private void ChoosePlayer(string yourName)
        {
            //Display main menu
            User user = new User();

            Console.WriteLine($"Hello {yourName}, Would you like to play against Thejets or TheSharks?(j/s)");

            Roshambo computerSelection;
            string userChoice = "";
            bool validChoice = true;
            while (validChoice)
            {
                userChoice = Console.ReadLine().ToLower();
                Roshambo YourSelection = user.GenerateRoshambo();

                validChoice = false;

                switch (userChoice)
                {
                    case "j":
                    case "Thejets":
                        computerSelection = TheJets.GenerateRoshambo();
                        PlayRoshambo(YourSelection, computerSelection);
                        break;
                    case "s":
                    case "TheSharks":
                        computerSelection = TheSharks.GenerateRoshambo();
                        PlayRoshambo(YourSelection, computerSelection);
                        break;
                    default:
                        validChoice = true;
                        Console.WriteLine("Please enter a valid selection (j/s)");
                        break;
                }

            }
        }
        private string GetUserName()
        {
            Console.Write("Please enter you Name: ");
            return Console.ReadLine();
        }

        public static void PlayRoshambo(Roshambo userPlayer, Roshambo computerPlayer)
        {
            User user = new User();
          

            // all possible scenarios
            if (userPlayer == computerPlayer)
            {
                Console.WriteLine("You tied! ");
            }
            else if ((userPlayer == Roshambo.rock) && (computerPlayer == Roshambo.scissors))
            {
                Console.WriteLine("You win!  ");
            }
            else if ((userPlayer == Roshambo.rock) && (computerPlayer == Roshambo.paper))
            {
                Console.WriteLine("You lose  ");
            }
            else if ((userPlayer == Roshambo.paper) && (computerPlayer == Roshambo.rock))
            {
                Console.WriteLine("You win  ");
            }
            else if ((userPlayer == Roshambo.paper) && (computerPlayer == Roshambo.scissors))
            {
                Console.WriteLine("You lose  ");
            }
            else if ((userPlayer == Roshambo.scissors) && (computerPlayer == Roshambo.paper))
            {
                Console.WriteLine("You win  ");
            }
            else if ((userPlayer == Roshambo.scissors) && (computerPlayer == Roshambo.rock))
            {
                Console.WriteLine("You lose  ");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


        //Method to ask user if they want to continue
        public static bool KeepGoing(string message, string option1, string option2)
        {
            string keepGoing = Validator.GetUserInput(message).ToLower();
            if (keepGoing == option1)
            {
                return true;
            }
            else if (keepGoing == option2)
            {
                return false;
            }
            else
            {
                return KeepGoing("Not valid! " + message, option1, option2);
            }
        }





    }
}