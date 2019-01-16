using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Deer : parent = Mammals

    abstract class Deer : Mammals
    {
        //changes the value of Legs and Deer can't climb

        public override int Legs { get; set; } = 4;
        public override bool Climbs(bool canClimb)
        {
            return false;
        }
        public override void Sleep()
        {

        }
        public override void Eat()
        {

        }
    }
}
