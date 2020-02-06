using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    class User : Player
    {

        public override  string Name { get; set; }
        public override Roshambo RoshamboValue { get; set; }


        public override Roshambo GenerateRoshambo()
        {
            // used method to ValidateUseInputRSP 
            string validResponse = Validator.ValidateUserInput(); //can only return 'r' 'p' or 's'
            if (validResponse == "r")
            {
                Console.WriteLine("You chose rock.");
                return Roshambo.rock;
            }
            else if (validResponse == "p")
            {
                Console.WriteLine("You chose paper.");
               return Roshambo.paper;

            }
            else
            {
                Console.WriteLine("You chose scissors.");
                return Roshambo.scissors;
            }
        }

        

    }
}
