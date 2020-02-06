using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    class TheSharks 
    {
        
        
        public static Roshambo RoshamboValue { get ; set ; }


        //Method to generate randon number
        public static Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            int randomSelection = rand.Next(1, 3);
            Roshambo[] selection = { Roshambo.rock, Roshambo.paper, Roshambo.scissors };
            Roshambo randomInput = selection[randomSelection];


            if (randomInput == Roshambo.rock)
            {
                Console.WriteLine("The Sharks chose rock");
            }
            else if (randomInput == Roshambo.paper)
            {
                Console.WriteLine("The Sharks chose paper.");
            }
            else
            {
                Console.WriteLine("The Sharks chose scissors.");
            }
            return randomInput;           
        }
            

        
    }
}
