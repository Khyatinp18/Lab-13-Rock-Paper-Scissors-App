using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_13_Rock_Paper_Scissors_App
{
    abstract class Player
    {
        //properties
        public abstract string Name { get; set; }
        public abstract  Roshambo RoshamboValue { get; set; }

        // default constructor
        public Player() { }

        //overloaded constructor
        public Player(string name, Roshambo roshamboValue)
        {
            Name = name;
            RoshamboValue = roshamboValue;
        }

        //abstact method
        public abstract Roshambo GenerateRoshambo(); 
        
    }
}
