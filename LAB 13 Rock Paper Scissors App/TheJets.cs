using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    class TheJets 
    {
        public static string Name { get ; set ; }
        public static Roshambo RoshamboValue { get; set; }

        public static Roshambo  GenerateRoshambo()
        {
            Console.WriteLine("The Sharks chose rock");
            return Roshambo.rock;
        }

    }
}
